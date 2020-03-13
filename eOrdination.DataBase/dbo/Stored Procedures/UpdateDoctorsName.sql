create procedure UpdateDoctorsName @id int, @name varchar(20)
as
begin
update Doctor
set name = @name
where id = @id
END