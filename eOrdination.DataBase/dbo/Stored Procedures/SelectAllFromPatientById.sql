create procedure SelectAllFromPatientById @id int
as
begin
		select * from Patient
		where id = @id
END