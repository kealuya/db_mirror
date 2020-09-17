package main

import (
	"github.com/astaxie/beego"
	"github.com/astaxie/beego/logs"
	_ "db_mirror/routers"
)

/*
	天下熙熙皆为利来，天下攘攘皆为利往
*/
func main() {
	//log初始化
	logInit()
	beego.Run()
}

func logInit() {
	_ = logs.SetLogger("console")
	_ = logs.SetLogger(logs.AdapterFile, `{"filename":"logs/project.log","level":7,"maxlines":0,"maxsize":0,"daily":true,"maxdays":365,"color":true,"separate":["error", "warning", "info", "debug"]}`)
	//输出文件名和行号
	logs.EnableFuncCallDepth(true)
	//异步输出log *配置*
	//logs.Async()
}

/*
todo 20200829
1,修改bug，初次备份时，需要进行全DB备份，不能因为smartlog而跳过该表。⭕️修改完成
2,考虑有主键的Table，可以设定更新标志为【update_date、update_time】等，并进行增量更新。
3,ui界面定制化
4,copy_ddl接口修改为只需传入"backup_id"就可    ⭕️修改完成
*/
