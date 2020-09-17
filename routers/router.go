package routers

import (
	"github.com/astaxie/beego"
	"github.com/astaxie/beego/context"
	"github.com/astaxie/beego/logs"
	. "db_mirror/controllers"
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
				/*初次使用 保存db备份策略*/
				beego.NSRouter("/save_backup_db_setting", &SettingController{}, "post:SaveBackupSetting"),
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
			),
		)
	//注册 namespace
	beego.AddNamespace(namespace)
	//过滤器-传入值记录
	beego.InsertFilter("*", beego.BeforeExec, func(context *context.Context) {
		logs.Info("记录请求log::", context.Input.Host(), context.Input.IP(), context.Input.Port(), string(context.Input.RequestBody))
	})
}