create database LoginForm;
use LoginForm;

create table log_tab(
user_name varchar(100) NOT NULL,
pass_word varchar(100) NOT NULL);

drop table log_tab;

insert into log_tab (user_name,pass_word) values ("mafas","password"); 

select * from log_tab;