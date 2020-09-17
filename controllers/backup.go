package controllers

import (
	"encoding/json"
	"fmt"
	"github.com/astaxie/beego"
	"github.com/astaxie/beego/logs"
	"github.com/robfig/cron"
	"strings"
	"db_mirror/db"
	"db_mirror/entity"
	"time"
)

var taskMap map[int]*cron.Cron = make(map[int]*cron.Cron)

type BackupController struct {
	beego.Controller
}

func (backupCtrl *BackupController) CopyDDL() {
	//初始化
	var returnJson []byte
	var timing time.Time = time.Now()
	defer func() {
		//返回值处理
		backupCtrl.Data["json"] = string(returnJson)
		backupCtrl.ServeJSON()
		logs.Info("Controller_CopyDDL花费时间::", time.Since(timing))
	}()
	var backup_db = new(entity.Backup_DB)
	var backup_db_json_byte = backupCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(backup_db_json_byte, &backup_db)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	createTableInfo, copyDdl_err := db.CopyDDL(*backup_db)
	if copyDdl_err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("目标数据库DDL文执行失败:", copyDdl_err), nil)
		return
	}
	// 成功的场合
	returnJson = returnValueMarshal(true, "目标数据库DDL文执行成功", createTableInfo)
}

func (backupCtrl *BackupController) GoCopy() {
	//初始化
	var returnJson []byte
	var timing time.Time = time.Now()
	defer func() {
		//返回值处理
		backupCtrl.Data["json"] = string(returnJson)
		backupCtrl.ServeJSON()
		logs.Info("Controller_GoCopy花费时间::", time.Since(timing))
	}()
	var backup_db = new(entity.Backup_DB)
	var backup_db_json_byte = backupCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(backup_db_json_byte, &backup_db)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	backup_db, err_dbbackup := db.Sqlite_NewDb().Sqlite_GetDbbackupSetting(backup_db.BackupId)
	if err_dbbackup != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}

	errlogs, goCopy_err := db.GoCopy(*backup_db)
	if goCopy_err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("目标数据库备份失败:", goCopy_err), nil)
		return
	}
	// 成功的场合
	returnJson = returnValueMarshal(true, "目标数据库备份成功", errlogs)
}

func (backupCtrl *BackupController) RunByBackupId() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		backupCtrl.Data["json"] = string(returnJson)
		backupCtrl.ServeJSON()
	}()
	var backup_db = new(entity.Backup_DB)
	var backup_db_json_byte = backupCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(backup_db_json_byte, &backup_db)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	backup_db, err_dbbackup := db.Sqlite_NewDb().Sqlite_GetDbbackupSetting(backup_db.BackupId)
	if err_dbbackup != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err_dbbackup), nil)
		return
	}
	// 执行方法制定
	goCopyFunc := func() {
		errLog, goCopy_err := db.GoCopy(*backup_db)
		if goCopy_err != nil {
			db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
				goCopy_err.Error()+"::"+strings.Join(errLog, "\n"))
		} else {
			if len(errLog) > 0 {
				// 执行记录
				db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
					strings.Join(errLog, "\n"))
			} else {
				// 执行记录
				db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
					"备份成功，没有发生错误")
			}
		}
	}

	// 定时处理 该定时字符串需要在前端控制住
	corn_string := backup_db.StrategySchedule
	// 创造cron，并保存到容器
	taskCron := cron.New()
	errTask := taskCron.AddFunc(corn_string, goCopyFunc)
	if errTask != nil {
		returnJson = returnValueMarshal(false, fmt.Sprintf("备份计划准备失败:%s", errTask), nil)
		return
	}
	taskCron.Start()
	taskMap[backup_db.BackupId] = taskCron

	// 首次执行备份程序
	go goFirstCopyFunc(backup_db)

	// 成功的场合
	returnJson = returnValueMarshal(true, "备份计划制定成功", nil)
}

func goFirstCopyFunc(backup_db *entity.Backup_DB) {

	b, b_err := db.Sqlite_NewDb().Sqlite_GetDbbackupSetting(backup_db.BackupId)
	if b_err != nil {
		// 怎么办呢~~
		db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
			"发生错误::"+b_err.Error())
		return
	}
	isFirst := false
	if b.SmartLogTime == "" {
		isFirst = true
	}
	errLog, goCopy_err := db.GoCopy(*backup_db, isFirst)
	if goCopy_err != nil {
		db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
			goCopy_err.Error()+"::"+strings.Join(errLog, "\n"))
	} else {
		if len(errLog) > 0 {
			// 执行记录
			db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
				strings.Join(errLog, "\n"))
		} else {
			// 执行记录
			db.Sqlite_NewDb().Sqlite_SaveRunLog(backup_db.BackupId,
				"备份成功，没有发生错误")
		}
	}
}

func (backupCtrl *BackupController) StopByBackupId() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		backupCtrl.Data["json"] = string(returnJson)
		backupCtrl.ServeJSON()
	}()
	var backup_db = new(entity.Backup_DB)
	var backup_db_json_byte = backupCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(backup_db_json_byte, &backup_db)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	backup_db, err_dbbackup := db.Sqlite_NewDb().Sqlite_GetDbbackupSetting(backup_db.BackupId)
	if err_dbbackup != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err_dbbackup), nil)
		return
	}

	taskCron, ok := taskMap[backup_db.BackupId]
	msg := ""
	if ok {
		taskCron.Stop()
		taskCron = nil
		delete(taskMap, backup_db.BackupId)
		msg = fmt.Sprintf("成功关闭[%s：%s]数据备份计划", backup_db.BackupId, backup_db.Desc)
	} else {
		msg = fmt.Sprintf("[%s：%s]数据备份计划已经关闭", backup_db.BackupId, backup_db.Desc)
	}
	// 成功的场合
	returnJson = returnValueMarshal(true, msg, nil)

}
