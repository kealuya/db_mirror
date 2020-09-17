package db

import (
	"encoding/json"
	"fmt"
	"github.com/astaxie/beego/logs"
	"gopkg.in/goracle.v2"
	_ "gopkg.in/goracle.v2"
	"regexp"
	"runtime"
	"strconv"
	"strings"
	"sync"
	"db_mirror/common"
	. "db_mirror/entity"
	"xorm.io/xorm"
	"xorm.io/xorm/log"
	"xorm.io/xorm/schemas"
)

type HandlerDb struct {
	Engine  *xorm.Engine
	Setting *Setting
}

var handlerDbMap map[int]*HandlerDb

func NewHandlerDb(db_id int) *HandlerDb {

	if val, ok := handlerDbMap[db_id]; ok {
		return val
	} else {
		if handlerDbMap == nil {
			handlerDbMap = make(map[int]*HandlerDb)
		}
		setting, err := Sqlite_NewDb().Sqlite_GetDbSetting(db_id)
		common.ErrorHandler(err, "sqlite获取DB配置错误::%s")
		// 获取引擎
		engine, err := xorm.NewEngine("goracle", GetDataSource(*setting))
		common.ErrorHandler(err, "sqlite打开发生错误::%s")
		/* 引擎配置 */
		engine.SetMaxIdleConns(10)
		engine.SetMaxOpenConns(2000)
		//engine.ShowSQL(true)
		// log配置到BeeLogger下
		engine.SetLogger(log.NewSimpleLogger(logs.GetBeeLogger()))
		engine.Logger().SetLevel(log.LOG_DEBUG)
		// *配置*
		engine.Logger().ShowSQL(false)

		handlerDbMap[db_id] = &HandlerDb{Engine: engine, Setting: setting} // 默认命名空间与用户名一致
		logs.Info(fmt.Sprintf("%s数据库Engine初始化成功", db_id))
		return handlerDbMap[db_id]
	}
}

func TestDb(s Setting) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("连接DB失败:%s", err)
	})

	// 获取引擎
	engine, err := xorm.NewEngine("goracle", GetDataSource(s))
	common.ErrorHandler(err)
	// 引擎关闭
	defer engine.Close()

	rows, err := engine.QueryString("select count(1) from dual")
	common.ErrorHandler(err)
	if rows != nil && len(rows) > 0 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("连接DB失败")
	}
}

/*
	拼接请求链接  结构参照 "SZHTCL/SZHTCL@114.115.146.150:1521/orcl"
*/
func GetDataSource(s Setting) string {
	return fmt.Sprint(s.Username, "/", s.Password, "@", s.Ip, ":", s.Port, "/", s.ServiceName)
}

func CopyDDL(backupDb Backup_DB) (createTableInfos []string, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("DB进行DDL操作失败:%s", err)
	})
	goroutineNum := 5
	if runtime.GOOS != "windows" {
		goroutineNum = 1
	}
	// 获取DbIdFrom和DbIdTo
	b, b_err := Sqlite_NewDb().Sqlite_GetDbbackupSetting(backupDb.BackupId)
	common.ErrorHandler(b_err)
	backupDb = *b

	handlerDb_from := NewHandlerDb(backupDb.DbIdFrom)
	engine_from := handlerDb_from.Engine
	setting_from := handlerDb_from.Setting

	handlerDb_to := NewHandlerDb(backupDb.DbIdTo)
	engine_to := handlerDb_to.Engine
	setting_to := handlerDb_to.Setting

	tables, err := engine_from.DBMetas()
	if err != nil {
		common.ErrorHandler(err)
	}

	// 考虑:重复建表的情况，记录每一次DDL，兼容追加表之后，在备份库追加该表的情况
	createTableInfos = []string{}

	type ddl_chan struct {
		table_info string
		ddl        string
		err        error
	}
	// 用于将来源疯狂输出
	channel_tables := make(chan *schemas.Table, goroutineNum)
	// 用于消费者发送处理后的数据
	channel_ddl := make(chan *ddl_chan, goroutineNum)
	wg := sync.WaitGroup{}
	wg.Add(len(tables))
	// 疯狂输出
	go func() {
		for _, t := range tables {
			channel_tables <- t
		}
		// 输出完成，close channel
		close(channel_tables)
	}()

	go func() {
		wg.Wait()
		// 消费者将处理过的数据进行发送，累计发送次数，然后关闭隧道
		close(channel_ddl)
	}()

	for i := 0; i < goroutineNum; i++ {
		//限流X个协程，如果发生非业务错误，就panic
		go func(channel_tables_in chan *schemas.Table) {
			// 对外错误处理
			defer common.RecoverHandler(func(err interface{}) {
				channel_ddl <- &ddl_chan{
					table_info: "",
					err:        fmt.Errorf("备份库创建表发生错误::%s", err),
				}
			})

			for t := range channel_tables_in {

				var valuesMap = make(map[string]string)
				_, err := engine_from.SQL(fmt.Sprintf("select dbms_metadata.get_ddl('TABLE','%s') as ddl from dual", t.Name)).Get(&valuesMap)
				if err != nil {
					common.ErrorHandler(err)
				}
				ddl := valuesMap["DDL"]
				// CREATE TABLE "SZHTCL"."CGAREABT"  修改命名空间  追加了用户名变大写
				ddl = strings.Replace(ddl, fmt.Sprintf(`CREATE TABLE "%s".`, strings.ToUpper(setting_from.Username)),
					fmt.Sprintf(`CREATE TABLE "%s".`, strings.ToUpper(setting_to.Username)), -1)
				// TABLESPACE "SZHTCL"   修改命名空间  追加了用户名变大写
				ddl = strings.Replace(ddl, fmt.Sprintf(`TABLESPACE "%s"`, strings.ToUpper(setting_from.Username)),
					fmt.Sprintf(`TABLESPACE "%s"`, strings.ToUpper(setting_to.Username)), -1)

				var createTableInfo string

				_, err_ddl := engine_to.Exec(ddl)
				if err_ddl != nil {
					if strings.Index(err_ddl.Error(), "ORA-00955") > 0 { //业务错误，不panic
						createTableInfo = fmt.Sprintf("Warning::备份库创建表失败，已经存在表[%s]", t.Name)
					} else {
						common.ErrorHandler(err_ddl, t.Name, ddl)
					}
				} else {
					createTableInfo = fmt.Sprintf("Info::备份库创建表成功，创建表[%s]", t.Name)
					// 执行建表ddl文成功，记录sqlite

					// 记入默认更新策略
					strategyMap := make(map[string]bool)
					strategyMap["isCopy"] = true
					strategyMap["hasPkForIncrement"] = true
					strategyMap["cleanCopy"] = false
					strategyMap["smartCopy"] = true
					strategyMapJsonByte, _ := json.Marshal(strategyMap)
					saveTblErr := Sqlite_NewDb().Sqlite_SaveBackupDbTableSetting(
						Backup_Table{
							BackupId:  backupDb.BackupId,
							TableName: t.Name,
							DDL:       ddl,
							Strategy:  string(strategyMapJsonByte),
							Key:       getKeyFromDdl(ddl),
						})
					common.ErrorHandler(saveTblErr)
				}
				logs.Info(createTableInfo)
				// 正常的场合
				channel_ddl <- &ddl_chan{
					table_info: createTableInfo,
					ddl:        ddl,
					err:        nil,
				}
				wg.Done()
			}
		}(channel_tables)
	}

	for c := range channel_ddl {
		if c.err != nil {
			common.ErrorHandler(c.err)
		} else {
			createTableInfos = append(createTableInfos, c.table_info)
		}
	}

	return createTableInfos, nil
}

func GoCopy(backupDb Backup_DB, isFirst ...bool) (errlogs []string, reErr error) {

	firstGo := false
	if isFirst != nil && len(isFirst) > 0 && isFirst[0] == true {
		logs.Info(fmt.Sprintf("%s,%s首次备份执行::firstGo=true", backupDb.BackupId, backupDb.Desc))
		firstGo = true
	}

	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("DB进行备份操作失败:%s", err)
	})

	handlerDb_from := NewHandlerDb(backupDb.DbIdFrom)
	engine_from := handlerDb_from.Engine

	handlerDb_to := NewHandlerDb(backupDb.DbIdTo)
	engine_to := handlerDb_to.Engine

	// 错误记录，主要用于返回发生错误的信息给调用者
	errLogs := []string{}
	errLogFunc := func(err_func error, err_sql string) {
		logs.Error(err_func, err_sql)
		errLogs = append(errLogs, err_func.Error(), err_sql)
	}

	bakTblsSetting, err := Sqlite_NewDb().Sqlite_GetDbTableSetting(backupDb.BackupId)
	common.ErrorHandler(err)

	bakTbl_chan := make(chan *Backup_Table, 10)
	wg := sync.WaitGroup{}

	wg.Add(len(bakTblsSetting))
	go func() {
		for _, b := range bakTblsSetting {
			bakTbl_chan <- b
		}
		close(bakTbl_chan)
	}()
	goroutineNum := 10
	if runtime.GOOS != "windows" {
		goroutineNum = 1
	}

	/*
		获取db执行log，获取被更新的表信息，用于判断某时间后，该表是否被更新过
		从而只能判断是否重新备份该表
	*/
	updateTables, errSmartLog := GetDbExecuteLog(backupDb)
	if errSmartLog != nil {
		common.ErrorHandler(errSmartLog)
	}

	for i := 0; i < goroutineNum; i++ {
		go func() {
			for b := range bakTbl_chan {
				/*
					strategy 表备份策略：
					1，是否需要备份
					2，根据主键增量备份（update or insert）
					3，完全清空备份表，从主表全量copy
					4，获取DB日志，只能判断该表是否有过更新操作，然后进行2或3的备份
					{
						"isCopy":true,
						"hasPkForIncrement":true,
						"cleanCopy":false,
						"smartCopy":true
					}
				*/
				strategyMap := make(map[string]bool)
				if firstGo {
					if b.Strategy == "" {
						// 第一次执行
						// 全盘备份
						strategyMap["isCopy"] = true
						strategyMap["hasPkForIncrement"] = false
						strategyMap["cleanCopy"] = true
						strategyMap["smartCopy"] = false
					} else {
						unmarshalJsonErr := json.Unmarshal([]byte(b.Strategy), &strategyMap)
						if unmarshalJsonErr != nil {
							errLogFunc(fmt.Errorf("解析[%s]表备份策略时发生错误::%s", b.TableName, unmarshalJsonErr), "")
							wg.Done()
							continue
						}
					}

				} else {
					// 非第一次执行
					if b.Strategy == "" {
						// 考虑表策略为空的情况，初始化 default
						strategyMap["isCopy"] = true
						strategyMap["hasPkForIncrement"] = true
						strategyMap["cleanCopy"] = false
						strategyMap["smartCopy"] = true
					} else {
						unmarshalJsonErr := json.Unmarshal([]byte(b.Strategy), &strategyMap)
						if unmarshalJsonErr != nil {
							errLogFunc(fmt.Errorf("解析[%s]表备份策略时发生错误::%s", b.TableName, unmarshalJsonErr), "")
							wg.Done()
							continue
						}
					}
				}

				//1，如果不需要备份，就跳过，减去wait
				if !strategyMap["isCopy"] {
					wg.Done()
					continue
				}
				//2,是否智能判断更新
				// -1:无关智能判断，后续正常执行
				// 0:智能判断，没有发生变化
				// 1:智能判断，发生变化
				smartCopyCheck := -1
				if strategyMap["smartCopy"] {
					// 需要智能判断
					smartCopyCheck = 0
					if backupDb.SmartLogTime == "" {
						// 没有更新时间，视为发生变化
						smartCopyCheck = 1
						logs.Info(fmt.Sprintf("表[%s]通过智能判断，备份时间记录为空，进行备份", b.TableName))
					} else {
						for _, u := range updateTables {
							if strings.ToUpper(u) == strings.ToUpper(b.TableName) {
								// 发生变化
								smartCopyCheck = 1
								logs.Info(fmt.Sprintf("表[%s]通过智能判断，发生变化，进行备份", b.TableName))
								break
							}
						}
					}
					// 没发生变化
					if smartCopyCheck == 0 {
						logs.Info(fmt.Sprintf("表[%s]通过智能判断，没有发生变化", b.TableName))
						wg.Done()
						continue
					}
				}

				// 获取目标表所有数据
				sql1 := "select * from " + b.TableName
				// 一次性获取所有 数据，集中处理
				results_map_interface, err := engine_from.SQL(sql1).QueryInterface()
				if err != nil {
					errLogFunc(fmt.Errorf("备份[%s]表时发生错误::%s", b.TableName, err), sql1)
					goto wgFlg
				}
				/*
					FIXME ❌🚫🚫⛔️⛔  特别注意~！以下代码中所有操作都是针对备份数据库表的，注意engine_to  ⛔️⛔🚫🚫️❌
				*/
				// 更新策略为主键更新，且该表拥有主key的情况下
				if strategyMap["smartCopy"] && b.Key != "" {
					for _, up := range results_map_interface {
						k := strings.Split(b.Key, ",")
						where_sql := ""
						for i, s := range k {
							switch up[s].(type) {
							case string:
								where_sql = where_sql + s + " = '" + up[s].(string) + "'"
							case int:
								where_sql = where_sql + s + " = " + strconv.Itoa(up[s].(int)) + ""
							case int64:
								where_sql = where_sql + s + " = " + strconv.FormatInt(up[s].(int64), 10) + ""
							case goracle.Number:
								where_sql = where_sql + s + " = " + up[s].(goracle.Number).String() + ""
							default:
								errLogFunc(fmt.Errorf("备份[%s]表时发生错误::key[%s]%s", b.TableName, s, "无法转换类型"), "")
								goto wgFlg
							}
							if i != len(k)-1 {
								where_sql = where_sql + " and "
							}
						}
						/*xorm 的 update ID 方式实在不会用了，谁会帮我把这块改了吧 FIXME*/
						updateNum, err := engine_to.Table(b.TableName).Where(where_sql).Update(up)
						if err != nil {
							sql2 := "tablename::" + b.TableName + " where_sql::" + where_sql + " Update::" + fmt.Sprintf("%+v", up)
							errLogFunc(fmt.Errorf("备份[%s]表时发生错误::%s", b.TableName, err), sql2)
							goto wgFlg
						}
						// update or insert
						if updateNum == 0 {
							_, err := engine_to.Table(b.TableName).Insert(up)
							if err != nil {
								sql3 := "tablename::" + b.TableName + " Insert::" + fmt.Sprintf("%+v", up)
								errLogFunc(fmt.Errorf("备份[%s]表时发生错误::%s", b.TableName, err), sql3)
								goto wgFlg
							}
						}
						//logs.Info("表 ["+b.TableName+"] ", "通过pk::", where_sql, " 备份成功")
					}
				} else {
					// 该表没有主key的情况下
					// 额外处理：判断原表是否有数据(数据量少于备份库)，如果原表为空，不进行清空备份表的操作
					if !countEqual(engine_from, engine_to, b.TableName) {
						errLogFunc(fmt.Errorf("[%s]表原库中数据少于备份库中数据，拒绝清空备份库后备份，请检查::", b.TableName), "")
						goto wgFlg
					}
					_, err_truncate := engine_to.Exec("TRUNCATE TABLE " + b.TableName)
					if err_truncate != nil {
						sql5 := "tablename::" + b.TableName + " TRUNCATE "
						errLogFunc(fmt.Errorf("备份[%s]表时发生错误::%s", b.TableName, err), sql5)
						goto wgFlg
					}
					_, err := engine_to.Table(b.TableName).Insert(results_map_interface)
					if err != nil {
						sql4 := "tablename::" + b.TableName + " Insert::" + fmt.Sprintf("%+v", results_map_interface)
						errLogFunc(fmt.Errorf("备份[%s]表时发生错误::%s", b.TableName, err), sql4)
						goto wgFlg
					}
					logs.Info("表 ["+b.TableName+"] ", "全插入成功")
				}
			wgFlg:
				wg.Done()
			}
		}()
	}

	wg.Wait()

	return errLogs, nil
}

func countEqual(engine_from *xorm.Engine, engine_to *xorm.Engine, tableName string) bool {
	mapStringInterfaceArray1, err := engine_from.SQL("select count(1) as num from " + tableName).QueryString()
	if err != nil {
		logs.Error(fmt.Errorf("查询[%s]表数据总量发生错误(from)::", tableName), "")
		return false
	}
	mapStringInterface1 := mapStringInterfaceArray1[0]
	from_num := mapStringInterface1["NUM"]
	from, _ := strconv.ParseInt(from_num, 10, 64)
	mapStringInterfaceArray2, err := engine_to.SQL("select count(1) as num from " + tableName).QueryString()
	if err != nil {
		logs.Error(fmt.Errorf("查询[%s]表数据总量发生错误(to)::", tableName), "")
		return false
	}
	mapStringInterface2 := mapStringInterfaceArray2[0]
	to_num := mapStringInterface2["NUM"]
	to, _ := strconv.ParseInt(to_num, 10, 64)
	return from >= to
}

func getKeyFromDdl(ddl string) string {
	// 例子 PRIMARY KEY ("ID", "TESTCOL")
	reg, err := regexp.Compile("PRIMARY KEY \\((.*)\\)")
	if err != nil {
		common.ErrorHandler(err)
	}
	ss := reg.FindStringSubmatch(ddl)
	if len(ss) == 2 {
		return strings.Replace(strings.Replace(ss[1], "\"", "", -1),
			" ", "", -1)
	} else {
		return ""
	}
}

func GetDbExecuteLog(backupDb Backup_DB) (updatedTables []string, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("获取DB操作日志失败:%s", err)
	})

	bk, err := Sqlite_NewDb().Sqlite_GetDbbackupSetting(backupDb.BackupId)
	common.ErrorHandler(err)
	// 拿出上次的时间，马上把这次时间存入
	// Backup_DB更新SmartLogTime
	// smartLogTime记录
	Sqlite_NewDb().Sqlite_UpdateSmartLogTime(backupDb.BackupId)

	updatedTables = make([]string, 0)

	// 没有更新时间，视为发生变化
	if bk.SmartLogTime == "" {
		return updatedTables, nil
	}

	// 获取 SCHEMA_NAME
	db_from_setting, setting_err := Sqlite_NewDb().Sqlite_GetDbSetting(backupDb.DbIdFrom)
	if setting_err != nil {
		common.ErrorHandler(setting_err)
	}

	handlerDb_from := NewHandlerDb(backupDb.DbIdFrom)
	engine_from := handlerDb_from.Engine
	dbELogArray := make([]DbExecuteLog, 0)
	dbELogSql := fmt.Sprintf(`
SELECT t.SQL_FULLTEXT as sql_full_text,
       t.FIRST_LOAD_TIME as first_load_time
FROM v$sqlarea t
WHERE to_date(t.FIRST_LOAD_TIME, 'yyyy-MM-dd hh24:mi:ss') > to_date('%s', 'yyyy-MM-dd hh24:mi:ss')
  AND t.PARSING_SCHEMA_NAME = '%s'
  AND (
        (INSTR(LOWER(t.SQL_FULLTEXT), 'update') > 0
            AND INSTR(LOWER(t.SQL_FULLTEXT), 'update') < 10)
        OR
        (INSTR(LOWER(t.SQL_FULLTEXT), 'insert') > 0
            AND INSTR(LOWER(t.SQL_FULLTEXT), 'insert') < 10)
    )
ORDER BY t.FIRST_LOAD_TIME DESC
`, bk.SmartLogTime, db_from_setting.Username)

	errFind := engine_from.SQL(dbELogSql).Find(&dbELogArray)
	if errFind != nil {
		common.ErrorHandler(errFind)
	}

	for _, dbElog := range dbELogArray {
		reg, _ := regexp.Compile(`(?i)update (\w+) |insert into (\w+) |update \w+\.(\w+) |insert into \w+\.(\w+) `)
		ss := reg.FindStringSubmatch(strings.Replace(dbElog.SqlFullText, "\"", "", -1))
		//logs.Info("smartLog匹配的表::", ss)
		// 处理重复
		if len(ss) > 0 {
			for i := 1; i < len(ss); i++ {
				if ss[i] != "" && !isDuplicate(updatedTables, ss[i]) {
					updatedTables = append(updatedTables, ss[i])
				}
			}
		}
	}
	logs.Info("updatedTables::", updatedTables)
	return
}

func isDuplicate(a []string, x string) bool {
	for i := 0; i < len(a); i++ {
		if a[i] == x {
			return true // 重复
		}
	}
	return false
}
