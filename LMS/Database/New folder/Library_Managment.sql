create database Library_Managment;
use Library_Managment; 

create table log_tab(
id int not null identity(1,1) primary key,
user_name varchar(100) not null,
pass_word varchar(100) not null);

insert into log_tab (user_name,pass_word) values ('mafas','mafas1234');

select * from log_tab;

