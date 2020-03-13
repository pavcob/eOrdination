CREATE TABLE [dbo].[Patient] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (20) NULL,
    [LastName]      VARCHAR (20) NULL,
    [idPatientFile] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idPatientFile]) REFERENCES [dbo].[PatientFile] ([id])
);

