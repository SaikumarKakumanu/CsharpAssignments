create database CodebasedExam
-- 2.Write a query to display your age in days
select DATEDIFF(dd,'2000/05/28','2022/05/30') AS DOB_NOOF_DAYS

--3.question solution
create table EMP8(Empid int primary key ,Name varchar(20),Salary int ,Deptno int)
insert  into EMP8 values(100,'',5000,10),(101,'',6000,20),(102,'',30000,30)
select * from EMP8

--3.b
alter table EMP8 add constraint salcheck check( salary between 5000 and 50000)



