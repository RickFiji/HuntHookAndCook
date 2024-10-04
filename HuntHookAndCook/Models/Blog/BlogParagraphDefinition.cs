namespace HuntHookAndCook.Models.Blog
{
    public class BlogParagraphDefinition
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }
        public string Subheading { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;

        public int BlogDefinitionId { get; set; }
        public BlogDefinition BlogDefinition { get; set; } = null!;
    }
}
