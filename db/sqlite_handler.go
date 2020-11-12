package db

import (
	"bytes"
	"database/sql"
	"db_mirror/common"
	"db_mirror/entity"
	"encoding/json"
	"fmt"
	"github.com/astaxie/beego/logs"
	"github.com/go-xorm/xorm"
	_ "github.com/mattn/go-sqlite3"
	"log"
	"reflect"
	"strconv"
	"sync"
)

type SqliteBakDb struct {
	Db     *sql.DB
	Engine *xorm.Engine
}

var bakDb *SqliteBakDb
var onceFunc_sqlite sync.Once

func Sqlite_NewDb() *SqliteBakDb {

	onceFunc_sqlite.Do(func() {
		db, err := sql.Open("sqlite3", "./db_bak.db")
		if err != nil {
			logs.Error(fmt.Errorf("sqlite打开发生错误::%s", err))
			log.Panicln(err)
		}

		engine, err := xorm.NewEngine("sqlite3", fmt.Sprintf("./db_bak.db"))
		if err != nil {
			logs.Error(fmt.Errorf("sqlite打开发生错误::%s", err))
			log.Panicln(err)
		}
		bakDb = &SqliteBakDb{Db: db, Engine: engine}
		logs.Info("SqliteDb初始化成功")
	})

	return bakDb
}

func (sb *SqliteBakDb) Sqlite_SaveDbSetting(setting entity.Setting) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("DB配置保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("insert into login_db ")
	sql.WriteString("(name,ip,port,service_name,username,password,update_time) ")
	sql.WriteString("values ")
	sql.WriteString("(?,?,?,?,?,?,datetime('now','localtime'))")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		setting.Name, setting.Ip, setting.Port,
		setting.ServiceName, setting.Username, setting.Password,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("DB配置保存失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_SaveTableSetting(setting entity.Setting) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("表配置保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("insert into login_db ")
	sql.WriteString("(name,ip,port,service_name,username,password,update_time) ")
	sql.WriteString("values ")
	sql.WriteString("(?,?,?,?,?,?,datetime('now','localtime'))")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		setting.Name, setting.Ip, setting.Port,
		setting.ServiceName, setting.Username, setting.Password,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("DB配置保存失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_GetDbSetting(db_id int) (setting *entity.Setting, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("获取DB配置信息失败:%s", err)
	})
	sql := bytes.Buffer{}
	sql.WriteString("select db_id,name,ip,port,service_name,username,password from login_db ")
	sql.WriteString("where db_id = ? ")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	row := stmt.QueryRow(db_id)
	mySetting := new(entity.Setting)
	getValFromRow(row, mySetting)

	if mySetting.DbId != 0 {
		return mySetting, nil
	} else {
		// 业务err
		return nil, fmt.Errorf("获取DB配置信息失败")
	}
}

func makeEntityArray(entity interface{}) []interface{} {
	entity_valueof := reflect.ValueOf(entity)
	num := entity_valueof.NumField()
	params := make([]interface{}, num)
	for i := 0; i < num; i++ {
		params[i] = entity_valueof.Field(i).Interface()
	}
	return params
}
func getValFromRow(row *sql.Row, target interface{}) {
	s := reflect.ValueOf(target).Elem()
	leng := s.NumField()
	onerow := make([]interface{}, leng)
	for i := 0; i < leng; i++ {
		onerow[i] = s.Field(i).Addr().Interface()
		field := reflect.ValueOf(target).Elem().Field(i)
		field.Set(reflect.ValueOf(onerow[i]).Elem())
	}

	row.Scan(onerow...)

}

func (sb *SqliteBakDb) Sqlite_SaveBackupDbSetting(backupSetting entity.Backup_DB) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("备份DB策略保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("insert into backup_db ")
	sql.WriteString("(db_id_from,db_id_to,desc,strategy_schedule,strategy_is_check_operate,update_time) ")
	sql.WriteString("values ")
	sql.WriteString("(?,?,?,?,?,datetime('now','localtime'))")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		backupSetting.DbIdFrom,
		backupSetting.DbIdTo,
		backupSetting.Desc,
		backupSetting.StrategySchedule,
		backupSetting.StrategyIsCheckOperate,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("备份DB策略保存失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_SaveBackupDbTableSetting(backupTableSetting entity.Backup_Table) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("备份表策略保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("insert into backup_db_table ")
	sql.WriteString("(backup_id,table_name,ddl,strategy,update_time,key) ")
	sql.WriteString("values ")
	sql.WriteString("(?,?,?,?,datetime('now','localtime'),?)")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		backupTableSetting.BackupId,
		backupTableSetting.TableName,
		backupTableSetting.DDL,
		backupTableSetting.Strategy,
		backupTableSetting.Key,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("备份表策略保存失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_GetDbTableSetting(backup_id int) (bakTblSetting []*entity.Backup_Table, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf(" :%s", err)
	})
	sql := bytes.Buffer{}
	sql.WriteString(`select backup_id,table_name,ddl,REPLACE ( REPLACE ( TRIM( strategy ), char ( 9 ), "" ), CHAR ( 10 ), "" ) as strategy ,key from backup_db_table `)
	sql.WriteString("where backup_id = ? ")

	err := sb.Engine.SQL(sql.String(), backup_id).Find(&bakTblSetting)
	common.ErrorHandler(err)

	return
}

func (sb *SqliteBakDb) Sqlite_GetAllDbTableSetting() (dbSetting []*entity.Setting, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf(" :%s", err)
	})
	sql := bytes.Buffer{}
	sql.WriteString("select db_id,name,ip,port,service_name,username from login_db ")

	err := sb.Engine.SQL(sql.String()).Find(&dbSetting)
	common.ErrorHandler(err)
	return
}

func (sb *SqliteBakDb) Sqlite_GetDbbackupSetting(backup_id int) (setting *entity.Backup_DB, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("获取DB备份策略信息失败:%s", err)
	})
	sql := bytes.Buffer{}
	sql.WriteString("select backup_id,db_id_from,db_id_to,desc,strategy_schedule,strategy_is_check_operate,datetime(smart_log_time) from backup_db ")
	sql.WriteString("where backup_id = ? ")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	row := stmt.QueryRow(backup_id)
	mySetting := new(entity.Backup_DB)
	getValFromRow(row, mySetting)

	if mySetting.Desc != "" {
		return mySetting, nil
	} else {
		// 业务err
		return nil, fmt.Errorf("获取DB备份策略信息失败")
	}
}

func (sb *SqliteBakDb) Sqlite_GetAllDbbackupSetting() (backupDbs []*entity.Backup_DB, reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("获取DB备份策略信息失败:%s", err)
	})
	sql := bytes.Buffer{}
	sql.WriteString("select backup_id,db_id_from,db_id_to,desc,strategy_schedule,strategy_is_check_operate,datetime(smart_log_time) from backup_db ")

	err := sb.Engine.SQL(sql.String()).Find(&backupDbs)
	common.ErrorHandler(err)
	return
}

func (sb *SqliteBakDb) Sqlite_SaveRunLog(backup_id int, runLog string) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		logs.Error(fmt.Errorf("记录备份log失败:%s", err))
	})

	sql := bytes.Buffer{}
	sql.WriteString("insert into run_log ")
	sql.WriteString("(backup_id,log,update_time) ")
	sql.WriteString("values ")
	sql.WriteString("(?,?,datetime('now','localtime'))")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	_, errStmt := stmt.Exec(
		backup_id,
		runLog,
	)
	common.ErrorHandler(errStmt)
}

func (sb *SqliteBakDb) Sqlite_UpdateSmartLogTime(backup_id int) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		logs.Error(fmt.Errorf("记录备份log失败:%s", err))
	})

	sql := bytes.Buffer{}
	sql.WriteString("update backup_db set ")
	sql.WriteString("smart_log_time = datetime('now','localtime') ")
	sql.WriteString("where backup_id = ?")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, errStmt := stmt.Exec(
		backup_id,
	)
	r, err := re.RowsAffected()
	if err != nil {
		common.ErrorHandler(err)
	}
	if r > 0 {
		logs.Info(fmt.Sprintf("更新策略[%s]的SmartTime成功", backup_id))
	}
	common.ErrorHandler(errStmt)
}

func (sb *SqliteBakDb) Sqlite_DelDbSetting(setting entity.Setting) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("DB配置保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("delete from login_db where db_id = ?")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		setting.DbId,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("DB配置删除失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_DelDbBackup(backupDb entity.Backup_DB) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("DB备份策略配置保存失败:%s", err)
	})

	sql := bytes.Buffer{}
	sql.WriteString("delete from backup_db where backup_id = ?")

	stmt, err := sb.Db.Prepare(sql.String())
	common.ErrorHandler(err)
	defer stmt.Close()

	re, err := stmt.Exec(
		backupDb.BackupId,
	)
	common.ErrorHandler(err)
	if ra, r_err := re.RowsAffected(); ra == 1 {
		return nil
	} else {
		// 业务err
		return fmt.Errorf("DB备份策略删除失败:%s", r_err)
	}
}

func (sb *SqliteBakDb) Sqlite_UpdateBackupTableSetting(backupTableSetting entity.BackupDbTableSetting) (reErr error) {
	// 对外错误处理
	defer common.RecoverHandler(func(err interface{}) {
		reErr = fmt.Errorf("更新备份表策略失败:%s", err)
	})

	backup_id := backupTableSetting.BackupID
	engine := sb.Engine
	for _, bt := range backupTableSetting.Data {
		b, err := json.Marshal(bt.Strategy)
		common.ErrorHandler(err, "更新备份表策略失败 -- "+strconv.Itoa(backup_id)+":"+bt.TableName)

		_, err = engine.Exec("update backup_db_table set strategy = ? where backup_id = ? and table_name = ?",
			string(b), backup_id, bt.TableName)
		common.ErrorHandler(err, "更新备份表策略失败 -- "+strconv.Itoa(backup_id)+":"+bt.TableName)
	}
	return nil
}
