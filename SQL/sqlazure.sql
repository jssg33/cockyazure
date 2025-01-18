use ce;
create table users (id int primary key, firstname varchar(50), lastname varchar(50), username varchar(100), email varchar(100), employee tinyint, employeeid varchar(100));
create table employees (id int primary key, employeeid varchar(100), employeetenure varchar(50), employeestartdate datetime, employee_returndate datetime, hrid varchar(100), hrsystemconstring varchar(250));
create table bu(id int primary key identity, buname varchar(100), buhqaddress1 varchar(150), buhqaddress2 varchar(150), buhqcity varchar(100), buhqstate varchar(100), buhqpostal varchar(100));
create table certifications (id int primary key identity, employee tinyint, employeeid varchar(100), certname varchar(150), revision varchar(50), certdate datetime, revisedate datetime, bu int, comments varchar(1000));
