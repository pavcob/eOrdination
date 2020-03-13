CREATE procedure [dbo].[UpdateDoctorById] @id int, @idOrdination int,  @Name varchar(20), @LastName varchar(20)
as
begin
	update Doctor
	set Name = @Name, idOrdination = @idOrdination, LastName = @LastName
	where id = @id
end; 