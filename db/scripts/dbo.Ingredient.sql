CREATE TABLE [dbo].[Ingredient]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [recipeId] INT NULL,
    [quantity] FLOAT NOT NULL, 
    [unit] NVARCHAR(20) NULL, 
    [name] NVARCHAR(300) NULL, 
    CONSTRAINT [FK_Ingredient_ToRecipe] FOREIGN KEY ([recipeId]) REFERENCES [Recipe]([Id]) 
)

GO

CREATE INDEX [IX_Ingredient_RecipeId] ON [dbo].[Ingredient] ([recipeId])
