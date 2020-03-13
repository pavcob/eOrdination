create procedure DeleteAppointmentById @id int
as
begin
	delete from Appointment
	where id = @id
END