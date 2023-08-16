create trigger delete_department ON DEPARTMENT after delete as
BEGIN
declare @id int
select @id = ID from deleted
delete from EMPLOYEE where ID = @id
delete from POSITION where ID = @id
END