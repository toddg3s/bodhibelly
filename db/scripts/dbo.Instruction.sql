CREATE TABLE [dbo].[Instruction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [recipeId] INT NOT NULL,
    [step] NVARCHAR(20) NOT NULL, 
    [description] TEXT NULL, 
    CONSTRAINT [FK_Instruction_ToRecipe] FOREIGN KEY ([recipeId]) REFERENCES [Recipe]([Id])
)

GO

CREATE INDEX [IX_Instruction_recipeId] ON [dbo].[Instruction] ([recipeId])
