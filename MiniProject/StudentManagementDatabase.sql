create database StudentManagementSystem
use StudentManagementSystem

create table Courses
(CId int primary key,CName varchar(20),Cduration int, Cfees float)

insert into Courses values(100,'Java',30,12000),(101,'DotNet',60,20000),(102,'Python',25,10000)

select * from Courses

create table Students
(StudentId int primary key,SName varchar(20),DOB date)

select * from Students

create table EnrollDetails
(Cid int foreign key references Courses(CId),
 StudId int foreign key references Students(StudentId),Paidfees float,
 EnrollDate date)

 insert into EnrollDetails values(102,3,5000,'5-May-2020'),(102,2,15000,'28-Aug-2019')

 select * from EnrollDetails


