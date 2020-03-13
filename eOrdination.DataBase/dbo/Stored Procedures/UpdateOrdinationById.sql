create procedure UpdateOrdinationById @id int, @speciality varchar(20)
as
begin
	update Ordination 
	set speciality = @speciality
	where id = @id
END