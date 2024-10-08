namespace HuntHookAndCook.Models.Recipe
{
    public class IngredientDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal? Quantity { get; set; }
        public string? Unit { get; set; }
        public int RecipeId { get; set; }
        public RecipeDefinition? Recipe { get; set; }
    }
}
