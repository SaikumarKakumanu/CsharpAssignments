create database StudentManagementSystem
use StudentManagementSystem

create table Courses
(CId int primary key,CName varchar(20),Cduration int, Cfees float)

select * from Courses

create table Students
(StudentId int primary key,SName varchar(20),DOB date)

select * from Students

create table EnrollDetails
(Cid int foreign key references Courses(CId),
 StudId int foreign key references Students(StudentId),
 EnrollDate date)

 select * from EnrollDetails

