create procedure GetDoctorById @id int
as
begin
	select * from Doctor
	where id = @id
end