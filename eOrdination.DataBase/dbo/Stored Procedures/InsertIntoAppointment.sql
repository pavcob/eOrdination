CREATE procedure [dbo].[InsertIntoAppointment] 
@idPatient int, @idDoctor int, @idOrdination int, @idMedicalReport int, @date datetime
as
begin
	insert into Appointment (idPatient, idDoctor, idOrdination, idMedicalReport, date)
	values (@idPatient, @idDoctor, @idOrdination, @idMedicalReport, @date)
end