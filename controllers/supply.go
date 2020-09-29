package controllers

import (
	"db_mirror/db"
	"db_mirror/entity"
	"encoding/json"
	"fmt"
	"github.com/astaxie/beego"
)

type SupplyController struct {
	beego.Controller
}

func (supplyCtrl *SupplyController) GetTableInfo() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		supplyCtrl.Data["json"] = string(returnJson)
		supplyCtrl.ServeJSON()
	}()
	backup_tbl := new(entity.Backup_Table)
	var supply_json_byte = supplyCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(supply_json_byte, &backup_tbl)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	bakTblSetting, err := db.Sqlite_NewDb().Sqlite_GetDbTableSetting(backup_tbl.BackupId)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}

	// 成功的场合
	returnJson = returnValueMarshal(true, "获取表信息成功", bakTblSetting)
}

func (supplyCtrl *SupplyController) GetAllDbSettingInfo() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		supplyCtrl.Data["json"] = string(returnJson)
		supplyCtrl.ServeJSON()
	}()

	dbSetting, err := db.Sqlite_NewDb().Sqlite_GetAllDbTableSetting()
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}

	// 成功的场合
	returnJson = returnValueMarshal(true, "获取所有DB配置信息成功", dbSetting)
}

func (supplyCtrl *SupplyController) GetAllDbbackupSettingInfo() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		supplyCtrl.Data["json"] = string(returnJson)
		supplyCtrl.ServeJSON()
	}()

	dbbackupSetting, err := db.Sqlite_NewDb().Sqlite_GetAllDbbackupSetting()
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}

	// 成功的场合
	returnJson = returnValueMarshal(true, "获取所有DB备份配置信息成功", dbbackupSetting)
}
