create trigger delete_position ON POSITION after delete as
BEGIN
declare @id int
select @id=ID from deleted
delete from EMPLOYEE where PositionID = @id
END