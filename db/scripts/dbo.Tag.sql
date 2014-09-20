CREATE TABLE [dbo].[Tag]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(200) NOT NULL, 
    [tagtypeId] INT NOT NULL, 
    CONSTRAINT [FK_Tag_ToTagType] FOREIGN KEY ([tagtypeId]) REFERENCES [TagType]([Id])
)
