CREATE VIEW [dbo].[RecipeTags]
	AS
	SELECT r.recipeId, t.Id tagId, tt.Id tagtypeId, t.name tagName, tt.name typeName 
	  FROM RecipeTag r INNER JOIN
		   Tag t ON r.tagId = t.Id INNER JOIN
		   TagType tt ON t.tagtypeId = tt.Id
