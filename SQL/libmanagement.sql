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
	bName nvarchar(250) not null,
	bAuthor nvarchar(250) not null,
	bPubl nvarchar(250) not null,
	bPDate varchar(250) not null,
	bPrice bigint not null,
	bQuan int not null
)
go
Create Table SINHVIEN
(
	stuid int not null IDENTITY(1,1) primary key,
	sname nvarchar(250) not null,
	enroll nvarchar(250) not null,
	dep nvarchar(250) not null,
	sem varchar(250) not null,
	contact bigint not null,
	email varchar(250) not null
)
go
Create Table MUONSACH
(
	id int not null IDENTITY(1,1) primary key,
	std_enroll varchar(250) not null,
	std_name varchar(250) not null,
	std_dep varchar(250) not null,
	std_sem varchar(250) not null,
	std_phone bigint not null,
	std_email varchar(250) not null,
	book_name varchar(250),
	book_issue_date varchar(250) not null,
	book_return_date varchar(250)
)

id,std_enroll,std_name,std_dep,std_sem,std_phone,std_email,book_name,book_issue_date,book_return_date
select * from MUONSACH