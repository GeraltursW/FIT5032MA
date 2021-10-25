CREATE TABLE [dbo].[Consultations] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Title] VARCHAR (MAX) NOT NULL,
    [Start] DATETIME      NOT NULL,
    [End] DATETIME NULL, 
    [Description] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

