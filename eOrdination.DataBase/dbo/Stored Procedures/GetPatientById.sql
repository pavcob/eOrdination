CREATE PROCEDURE [GetPatientById] @id int
AS
BEGIN
	SELECT * FROM Patient 
	WHERE id = @id
END;