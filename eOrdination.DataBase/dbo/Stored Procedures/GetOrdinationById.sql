create procedure [GetOrdinationById] @id int
as
begin
	select * from Ordination
	where id = @id
END