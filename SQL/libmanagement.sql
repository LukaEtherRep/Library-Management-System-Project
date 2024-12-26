Create Database LibraryManagementSystem

---------------------------------------------
use LibraryManagementSystem
go

Create Table TAIKHOAN
(
	id int not null IDENTITY(1,1) primary key,
	username varchar(150) not null,
	passcode varchar(150) not null
)

Insert into TAIKHOAN (username, passcode) values ('23520635','Kabaneri1')
select * from TAIKHOAN

Create Table SACH
(
	bid int not null IDENTITY(1,1) primary key,
	bName varchar(250) not null,
	bAuthor varchar(250) not null,
	bPubl varchar(250) not null,
	bPDate varchar(250) not null,
	bPrice bigint not null,
	bQuan int not null
)
go
bName, bAuthor, bPubl, bPDate, bPrice, bQuan

Select * from SACH

alter table SACH
alter column bName nvarchar(500) not null
go
alter table SACH
alter column bAuthor nvarchar(250) not null
go
alter table SACH
alter column bPubl nvarchar(250) not null