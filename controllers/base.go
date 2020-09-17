package controllers

import "encoding/json"

type ResponseJson struct {
	Success bool        `json:"success"`
	Msg     string      `json:"msg"`
	Data    interface{} `json:"data"`
}

func returnValueMarshal(isSuccess bool, payload string, data interface{}) []byte {
	r, _ := json.Marshal(ResponseJson{
		Success: isSuccess,
		Msg:     string(payload),
		Data:    data,
	})
	return r
}
