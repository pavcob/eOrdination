CREATE TABLE [dbo].[Appointment] (
    [id]              INT      IDENTITY (1, 1) NOT NULL,
    [idPatient]       INT      NULL,
    [idDoctor]        INT      NULL,
    [idOrdination]    INT      NULL,
    [idMedicalReport] INT      NULL,
    [date]            DATETIME NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idDoctor]) REFERENCES [dbo].[Doctor] ([id]),
    FOREIGN KEY ([idMedicalReport]) REFERENCES [dbo].[MedicalReport] ([id]),
    FOREIGN KEY ([idOrdination]) REFERENCES [dbo].[Ordination] ([id]),
    FOREIGN KEY ([idPatient]) REFERENCES [dbo].[Patient] ([id])
);

