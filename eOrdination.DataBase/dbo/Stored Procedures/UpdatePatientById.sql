CREATE PROCEDURE [dbo].[UpdatePatientById] @id int,
@Name varchar(20), @LastName varchar(20), @idPatientFile int
AS
BEGIN
UPDATE Patient
SET Name = @Name , LastName = @LastName, idPatientFile = @idPatientFile
WHERE id = @id
END