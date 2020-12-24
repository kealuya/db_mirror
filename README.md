### db_mirror
Because the server is often attacked by blackmail virus, Oracle database paralysis brings great problems,
Therefore, this application is developed to synchronize database data. When problems occur in other machines, the data source can be switched in time.
Configure the original dB and the target dB, and backup them according to a certain cycle.
At the same time, the corresponding backup strategy can be configured according to each table of DB, including full backup, primary key backup and intelligent analysis backup.
1. Provide database connection test.
2. Provide backup database DLL information.
3. Provide multiple backup strategies for each table, including full backup, primary key backup and intelligent analysis backup.
The intelligent analysis backup is analyzed according to Oracle data update log to decide whether to backup.
4. Distributed.
5. Multithreading and low power consumption.
---
根据配置备份原DB，目标备份DB，按照一定周期进行备份。

同时可以根据DB每个表配置相应的备份策略。

当前功能：
![Image text](https://raw.githubusercontent.com/kealuya/db_mirror/master/img/design.png)

程序用sqlite的DDL

create table backup_db
(
	backup_id INTEGER not null
		constraint backup_db_pk
			primary key autoincrement,
	db_id_from INTEGER not null,
	db_id_to INTEGER not null,
	desc string,
	strategy_schedule string,
	strategy_is_check_operate bool,
	update_time date,
	smart_log_time date
);

create table backup_db_table
(
	backup_id int,
	table_name string,
	ddl string,
	strategy string,
	update_time date,
	key string,
	constraint backup_db_table_pk
		primary key (backup_id, table_name)
);

create table login_db
(
	db_id INTEGER not null
		constraint login_db_pk
			primary key autoincrement,
	name string,
	ip string,
	port string,
	service_name string,
	username string,
	password string,
	update_time date
);

create unique index login_db_db_id_uindex
	on login_db (db_id);

create table run_log
(
	backup_id int,
	log string,
	update_time date
);


