create procedure DeletePatientFileById @id int
as
begin
	delete from PatientFile 
	where id = @id
end