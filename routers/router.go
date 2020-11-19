package routers

import (
	. "db_mirror/controllers"
	"github.com/astaxie/beego"
	"github.com/astaxie/beego/context"
	"github.com/astaxie/beego/logs"
)

func init() {

	namespace :=
		beego.NewNamespace("/v1",
			beego.NSNamespace("/setting",
				/*DB配置检查*/
				beego.NSRouter("/is_running", &SettingController{}, "post:IsRunning"),
				/*DB配置检查*/
				beego.NSRouter("/test_db", &SettingController{}, "post:TestDb"),
				/*DB配置录入*/
				beego.NSRouter("/save_db_setting", &SettingController{}, "post:SaveDbSetting"),
				/*DB配置删除*/
				beego.NSRouter("/del_db_setting", &SettingController{}, "post:DelDbSetting"),
				/*DB备份策略配置删除*/
				beego.NSRouter("/del_db_backup", &SettingController{}, "post:DelDbBackup"),
				/*初次使用 保存db备份策略*/
				beego.NSRouter("/save_backup_db_setting", &SettingController{}, "post:SaveBackupSetting"),
				/*DB配置录入*/
				beego.NSRouter("/update_backup_table_setting", &SettingController{}, "post:UpdateBackupTableSetting"),
			),
			beego.NSNamespace("/backup",
				/*初次使用 db结构copy*/
				beego.NSRouter("/copy_ddl", &BackupController{}, "post:CopyDDL"),
				/*初次使用 执行单次备份*/
				beego.NSRouter("/go_copy", &BackupController{}, "post:GoCopy"),
				/*备份策略执行*/
				beego.NSRouter("/run_backup", &BackupController{}, "post:RunByBackupId"),
				/*备份策略停止*/
				beego.NSRouter("/stop_backup", &BackupController{}, "post:StopByBackupId"),
			),
			beego.NSNamespace("/supply",
				/*获取表信息，用于展示并让用户选择表备份策略*/
				beego.NSRouter("/supply_tbl_info", &SupplyController{}, "post:GetTableInfo"),
				/*获取表信息，用于展示并让用户选择表备份策略*/
				beego.NSRouter("/supply_all_db_info", &SupplyController{}, "post:GetAllDbSettingInfo"),
				/*获取db备份信息，用于展示*/
				beego.NSRouter("/supply_all_db_backup_info", &SupplyController{}, "post:GetAllDbbackupSettingInfo"),
				/*获取备份策略是否执行中*/
				beego.NSRouter("/supply_is_run", &SupplyController{}, "post:GetBackupIsRun"),
			),
		)
	//注册 namespace
	beego.AddNamespace(namespace)
	//过滤器-传入值记录
	beego.InsertFilter("*", beego.BeforeExec, func(context *context.Context) {
		logs.Info("记录请求log::", context.Input.Host(), context.Input.IP(), context.Input.Port(), string(context.Input.RequestBody))
	})
}
