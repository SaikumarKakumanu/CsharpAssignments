create database EmployeeManagement

create table Code_Employee ( empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000) , 
emptype varchar(1) check(emptype in('C','P')) ) 

insert into Code_Employee values
(101,'Saikumar',28000,'P')

select * from Code_Employee

create or alter proc AddEmployee(@ename varchar(50),@esal numeric(10,2),@etype varchar(1))
as
begin
declare @eid int =(select max(empno) from Code_Employee)
begin
declare @empid int = @eid + 1;
insert into Code_Employee values(@empid,@ename,@esal,@etype)
end
end

execute AddEmployee @ename='Sai',@esal=30000,@etype='C'
