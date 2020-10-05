package main

import (
	"db_mirror/db"
	"fmt"
)

type ss struct {
	a string
	b int
}
type NEIKONG_CL_EMPLOYEE_INFO struct {
	ID          string `xorm:"ID"`
	USERID      string `xorm:"USERID"`
	PASSWORD    string `xorm:"PASSWORD"`
	CHINESENAME string `xorm:"CHINESENAME"`
}

func (NEIKONG_CL_EMPLOYEE_INFO) TableName() string {
	return "NEIKONG_CL_EMPLOYEE_INFO"
}
func main() {

	//nce := NEIKONG_CL_EMPLOYEE_INFO{
	//	USERID:      "33333",
	//	PASSWORD:    "2222",
	//	CHINESENAME: "买买买",
	//}
	//
	db := db.NewHandlerDb(4)
	en := db.Engine
	//a, err := en.Insert(&nce)
	//if err != nil {
	//	fmt.Println(err)
	//}
	//
	//fmt.Println("affect=", a, nce.ID)

	r, err := en.SQL("SELECT NEXTVAL FROM dual ").QueryString()
	if err != nil {
		fmt.Println(err)
		fmt.Println(err.Error())
	}
	fmt.Println(r)
}
