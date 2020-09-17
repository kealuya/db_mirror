package controllers

import (
	"encoding/json"
	"fmt"
	"github.com/astaxie/beego"
	"db_mirror/db"
	. "db_mirror/entity"
)

type SettingController struct {
	beego.Controller
}

/*
	检测db配置是否正确
*/
func (settingCtrl *SettingController) IsRunning() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		settingCtrl.Data["json"] = string(returnJson)
		settingCtrl.ServeJSON()
	}()

	// 成功的场合
	returnJson = returnValueMarshal(true, "接口程序启动成功", nil)
}

/*
	检测db配置是否正确
*/
func (settingCtrl *SettingController) TestDb() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		settingCtrl.Data["json"] = string(returnJson)
		settingCtrl.ServeJSON()
	}()
	var setting = new(Setting)
	var setting_json_byte = settingCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(setting_json_byte, &setting)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	//业务处理
	//db链接测试
	if err := db.TestDb(*setting); err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}
	// 成功的场合
	returnJson = returnValueMarshal(true, "DB链接测试成功", nil)
}

/*
	保存db配置
*/
func (settingCtrl *SettingController) SaveDbSetting() {

	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		settingCtrl.Data["json"] = string(returnJson)
		settingCtrl.ServeJSON()
	}()
	var setting = new(Setting)
	var setting_json_byte = settingCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(setting_json_byte, &setting)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	//业务处理
	//db链接测试
	if err := db.TestDb(*setting); err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint(err), nil)
		return
	}
	// 成功的场合 - 保存db配置
	if save_err := db.Sqlite_NewDb().Sqlite_SaveDbSetting(*setting); save_err == nil {
		returnJson = returnValueMarshal(true, "DB配置信息保存成功", nil)
	} else {
		returnJson = returnValueMarshal(false, fmt.Sprint(save_err), nil)
	}
	return
}

func (backupCtrl *SettingController) SaveBackupSetting() {
	//初始化
	var returnJson []byte
	defer func() {
		//返回值处理
		backupCtrl.Data["json"] = string(returnJson)
		backupCtrl.ServeJSON()
	}()
	var backup_db = new(Backup_DB)
	var backup_db_json_byte = backupCtrl.Ctx.Input.RequestBody

	//传入json转化对象
	err := json.Unmarshal(backup_db_json_byte, &backup_db)
	if err != nil {
		returnJson = returnValueMarshal(false, fmt.Sprint("传入参数json转换失败:", err), nil)
		return
	}

	// 成功的场合 - 保存db配置
	if backup_err := db.Sqlite_NewDb().Sqlite_SaveBackupDbSetting(*backup_db); backup_err == nil {
		returnJson = returnValueMarshal(true, "备份DB策略保存成功", nil)
	} else {
		returnJson = returnValueMarshal(false, fmt.Sprint(backup_err), nil)
	}
	return
}
