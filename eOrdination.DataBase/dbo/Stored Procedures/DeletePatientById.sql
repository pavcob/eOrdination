CREATE PROCEDURE [DeletePatientById] @id int
AS
BEGIN
	Delete  FROM Patient
	WHERE id = @id
END