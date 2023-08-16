create trigger delete_employee ON EMPLOYEE
after delete as
BEGIN
declare @id int
select @id  ID from deleted
delete from TASK where EmployeeId=@id
delete from SALARY where EmployeeId=@id
delete from PERMISSION where EmployeeId=@id
END