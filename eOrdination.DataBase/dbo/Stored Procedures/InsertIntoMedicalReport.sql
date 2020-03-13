CREATE PROCEDURE InsertIntoMedicalReport @Report varchar(50)
AS
BEGIN
	INSERT INTO MedicalReport(Report)
	VALUES (@Report)
END