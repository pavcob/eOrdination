CREATE TABLE [dbo].[Doctor] (
    [id]           INT          IDENTITY (1, 1) NOT NULL,
    [idOrdination] INT          NULL,
    [Name]         VARCHAR (50) NULL,
    [LastName]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idOrdination]) REFERENCES [dbo].[Ordination] ([id])
);

