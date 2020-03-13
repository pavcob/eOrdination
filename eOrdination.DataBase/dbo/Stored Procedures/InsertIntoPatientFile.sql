create procedure InsertIntoPatientFile @idMedicalReport int
as
begin
insert into PatientFile (idMedicalReport)
values (@idMedicalReport)
end