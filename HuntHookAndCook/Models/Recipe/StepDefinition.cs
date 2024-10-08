namespace HuntHookAndCook.Models.Recipe
{
    public class StepDefinition
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string? Description { get; set; }
        public int RecipeId { get; set; }
        public RecipeDefinition? Recipe { get; set; }
    }
}
