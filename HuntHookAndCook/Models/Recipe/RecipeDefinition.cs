namespace HuntHookAndCook.Models.Recipe
{
    public class RecipeDefinition
    {
        public int Id { get; set; }
        public CategoryDefinition? Category { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public byte[]? Image { get; set; }
        public List<IngredientDefinition>? Ingredients { get; set; }
        public List<StepDefinition>? Steps { get; set; }
    }
}
