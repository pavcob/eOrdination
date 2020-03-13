create procedure DeleteDoctorById @id int
as
begin
	delete from Doctor 
	where id = @id
end