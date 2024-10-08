﻿--select * from dbo.Category
select * from dbo.Recipe
--select * from dbo.Ingredient
--select * from dbo.Step

select 
	c.Name as CategoryName,
	r.Title as RecipeName,
	i.Name as IngredientName,
	i.Quantity,
	i.Unit
from dbo.Recipe r
left join dbo.Category c on c.Id = r.CategoryId 
left join dbo.Ingredient i on r.Id = i.RecipeId

select 
	c.Name as CategoryName,
	r.Title as RecipeName,
	s.[Order],
	s.Description
from dbo.Recipe r
left join dbo.Category c on c.Id = r.CategoryId 
left join dbo.Step s on r.Id = s.RecipeId

--Insert into dbo.Category values ('Fish'),('Venison'),('Boar'),('Bear'),('Bobcat'),('Duck')
--declare @categoryId int = (select top 1 Id from dbo.Category where Name = 'Venison')
--Insert into dbo.Recipe values (@categoryId,'Elk Soup','Very yummy!', 'Let me tell you a short story about this soup.',null)
--declare @recipeId int = (select top 1 Id from dbo.Recipe )
--Insert into dbo.Ingredient values 
--	('Venison',1,'lbs',@recipeId),
--	('Water',4,'cups',@recipeId),
--	('Salt',1,'tbpn',@recipeId)
--Insert into dbo.Step values 
--	(1,'Boil Water',@recipeId),
--	(2,'Add meat',@recipeId),
--	(3,'Wait',@recipeId),
--	(4,'Eat',@recipeId)