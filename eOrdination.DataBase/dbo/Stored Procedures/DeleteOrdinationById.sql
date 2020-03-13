create procedure DeleteOrdinationById @id int
as
begin
	delete from Ordination
	where id = @id
end