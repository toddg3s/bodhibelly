CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [recipeId] INT NOT NULL, 
    [rating] INT NULL, 
    [description] TEXT NULL, 
    [reviewed] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Review_ToRecipe] FOREIGN KEY ([recipeId]) REFERENCES [Recipe]([Id])
)

GO

CREATE INDEX [IX_Review_RecipeId] ON [dbo].[Review] ([recipeId])
