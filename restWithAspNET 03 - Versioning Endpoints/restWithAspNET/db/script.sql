create table persons (
id int(10) unsigned null default null,
firstName varchar (50) null default null,
lasttName varchar (50) null default null,
adress varchar (50) null default null,
gender varchar (50) null default null
)charset = utf8;

alter table persons change id id int(10) auto_increment  primary key;

	alter table persons change lasttName lastName varchar (50) null default null;
