CREATE TABLE [dbo].[PatientFile] (
    [id]              INT IDENTITY (1, 1) NOT NULL,
    [idMedicalReport] INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idMedicalReport]) REFERENCES [dbo].[MedicalReport] ([id])
);

