create procedure DeleteMedicalReportById @id int
as
begin
	delete from MedicalReport 
	where id = @id
end