namespace HuntHookAndCook.Models.Blog
{
    public class BlogDefinition
    {
        public int Id { get; set; }
        public byte[]? BannerImage { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public List<BlogParagraphDefinition>? Paragraphs { get; set; }
    }
}
