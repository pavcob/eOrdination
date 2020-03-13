create procedure InsertIntoOrdination @speciality varchar(20)
as
begin
	insert into Ordination(speciality)
	values(@speciality)
end