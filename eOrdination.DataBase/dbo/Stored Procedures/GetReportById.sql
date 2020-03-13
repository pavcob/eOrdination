CREATE PROCEDURE [GetReportById] @id int
AS
BEGIN
	SELECT * FROM MedicalReport
	WHERE id = @id
END;