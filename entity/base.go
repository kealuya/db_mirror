package entity

type Setting struct {
	DbId        int    `json:"db_id"`
	Name        string `json:"name"`
	Ip          string `json:"ip"`
	Port        string `json:"port"`
	ServiceName string `json:"service_name"`
	Username    string `json:"username"`
	Password    string `json:"password"`
}

type Backup_DB struct {
	BackupId               int    `json:"backup_id"`
	DbIdFrom               int    `json:"db_id_from"`
	DbIdTo                 int    `json:"db_id_to"`
	Desc                   string `json:"desc"`
	StrategySchedule       string `json:"strategy_schedule"`
	StrategyIsCheckOperate bool   `json:"strategy_is_check_operate"`
	SmartLogTime           string `json:"smart_log_time"`
}

type Backup_Table struct {
	BackupId  int    `json:"backup_id"`
	TableName string `json:"table_name"`
	DDL       string `json:"ddl"`
	Strategy  string `json:"strategy"`
	Key       string `json:"key"`
}

type Run_Log struct {
	BackupId   int    `json:"backup_id"`
	Log        string `json:"log"`
	UpdateTime string `json:"update_time"`
}
type DbExecuteLog struct {
	SqlFullText   string `json:"sql_full_text"`
	FirstLoadTime string `json:"first_load_time"`
}
