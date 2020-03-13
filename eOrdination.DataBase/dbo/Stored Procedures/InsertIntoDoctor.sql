CREATE procedure [dbo].[InsertIntoDoctor] @Name varchar(20), @LastName varchar(20), @idOrdination int
as
begin
	insert into Doctor (Name, LastName, idOrdination)
	values (@Name, @LastName, @idOrdination)
end