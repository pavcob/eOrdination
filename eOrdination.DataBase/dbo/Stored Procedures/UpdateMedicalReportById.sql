create procedure UpdateMedicalReportById @id int, @Report varchar(50)
as
begin
	update MedicalReport
	set Report = @Report
	where id = @id
end