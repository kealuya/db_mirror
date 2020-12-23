package main

import (
	"db_mirror/common"
	_ "db_mirror/routers"
	"github.com/astaxie/beego"
	"github.com/astaxie/beego/logs"
	"io/ioutil"
	"net/http"

	"github.com/axgle/mahonia"      // 解决C语言字符乱码问题
	"github.com/cratonica/trayhost" // 提供托盘管理

	// pprof 的init函数会将pprof里的一些handler注册到http.DefaultServeMux上
	// 当不使用http.DefaultServeMux来提供http api时，可以查阅其init函数，自己注册handler
	_ "net/http/pprof"
)

/*
	天下熙熙皆为利来，天下攘攘皆为利往
*/

func main() {

	go func() {
		http.ListenAndServe("0.0.0.0:8081", nil)
	}()

	go func() {
		main1()
		// 业务处理
	}()

	path := common.GetCurrentPath()                   // 获取exe当前路径
	f, err := ioutil.ReadFile(path + "/" + "dbm.ico") // 读取当前目录下的ico图标
	if err != nil {
		f = nil
	}
	enc := mahonia.NewEncoder("gb18030")                 // 将传送的字符进行编码
	trayhost.EnterLoop(enc.ConvertString("浩天DB备份服务"), f) // 设定托盘气泡汉字

}

func main1() {
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
