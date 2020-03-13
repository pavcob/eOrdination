create procedure GetAppointmentById @id int 
as
begin
	select * from Appointment
	where id = @id
end