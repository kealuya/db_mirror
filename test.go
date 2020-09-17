package main

import (
	"fmt"
	"db_mirror/db"
)

type ss struct {
	a string
	b int
}


func main() {

	db  := db.NewHandlerDb(3)
	en:=db.Engine
	r,err:= en.SQL("select * from ddd").QueryString()
	if err != nil {
		fmt.Println(err)
		fmt.Println(err.Error())
	}

	fmt.Println(r)
}
