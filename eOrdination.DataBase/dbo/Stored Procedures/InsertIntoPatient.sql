CREATE PROCEDURE [dbo].[InsertIntoPatient] 
@Name varchar(20), @LastName varchar(20), @idPatientFile int
AS
BEGIN
	INSERT INTO	Patient(Name, LastName, idPatientFile)
	VALUES (@Name , @LastName, @idPatientFile )
END; 		