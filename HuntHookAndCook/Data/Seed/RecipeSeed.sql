--select * from dbo.Recipe
--select * from dbo.Ingredient
--select * from dbo.Step

select 
	r.Category,
	r.Title as RecipeName,
	i.Name as IngredientName,
	i.Quantity,
	i.Unit
from dbo.Recipe r
left join dbo.Ingredient i on r.Id = i.RecipeId

select 
	r.Category,
	r.Title as RecipeName,
	s.[Order],
	s.Description
from dbo.Recipe r
left join dbo.Step s on r.Id = s.RecipeId

--Insert into dbo.Recipe values ('Venison','Soup','Yummy',null)
declare @recipeId int = (select top 1 Id from dbo.Recipe )
--Insert into dbo.Ingredient values 
--	('Venison',1,'lbs',@recipeId),
--	('Water',4,'cups',@recipeId),
--	('Salt',1,'tbspn',@recipeId)
--Insert into dbo.Step values 
--	(1,'Boil Water',@recipeId),
--	(2,'Add meat',@recipeId),
--	(3,'Wait',@recipeId),
--	(4,'Eat',@recipeId)