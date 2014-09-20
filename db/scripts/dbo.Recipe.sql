CREATE TABLE [dbo].[Recipe] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (200) NULL,
    [link]        VARCHAR (500)  NULL,
    [picture]     VARCHAR (500)  NULL,
    [posted]      DATETIME       NULL,
    [avgrating]   FLOAT (53)     NULL,
    [description] TEXT           NULL,
    [servings] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

