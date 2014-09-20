CREATE TABLE [dbo].[RecipeTag]
(
	[recipeId] INT NOT NULL , 
    [tagId] INT NOT NULL, 
    PRIMARY KEY ([recipeId], [tagId]), 
    CONSTRAINT [FK_RecipeTag_ToRecipe] FOREIGN KEY ([recipeId]) REFERENCES [Recipe]([Id]), 
    CONSTRAINT [FK_RecipeTag_ToTag] FOREIGN KEY ([tagId]) REFERENCES [Tag]([Id])
)
