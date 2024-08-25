namespace HuntHookAndCook.Models
{
    public class RecipeDefinition
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
        public List<IngredientDefinition>? Ingredients { get; set; } 
        public List<StepDefinition>? Steps { get; set; } 
    }
}
