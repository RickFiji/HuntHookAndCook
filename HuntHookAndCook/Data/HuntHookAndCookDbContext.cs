using HuntHookAndCook.Models.Blog;
using HuntHookAndCook.Models.Recipe;
using Microsoft.EntityFrameworkCore;

namespace HuntHookAndCook.Data
{
    public class HuntHookAndCookDbContext : DbContext
    {
        // Recipe
        public DbSet<RecipeDefinition> Recipe { get; set; }
        public DbSet<CategoryDefinition> Category { get; set; }
        public DbSet<IngredientDefinition> Ingredient { get; set; }
        public DbSet<StepDefinition> Step { get; set; }

        public DbSet<BlogDefinition> Blogs { get; set; }
        public DbSet<BlogParagraphDefinition> BlogParagraphs { get; set; }

        // Blog
        public HuntHookAndCookDbContext(DbContextOptions<HuntHookAndCookDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecipeDefinition>()
                .HasMany(r => r.Ingredients)
                .WithOne(i => i.Recipe)
                .HasForeignKey(i => i.RecipeId);

            modelBuilder.Entity<IngredientDefinition>()
                .Property(i => i.Quantity)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<RecipeDefinition>()
                .HasMany(r => r.Steps)
                .WithOne(s => s.Recipe)
                .HasForeignKey(s => s.RecipeId);

            modelBuilder.Entity<RecipeDefinition>()
                .HasOne(r => r.Category);


            modelBuilder.Entity<BlogParagraphDefinition>()
                .HasOne(bp => bp.BlogDefinition)
                .WithMany(b => b.Paragraphs)
                .HasForeignKey(bp => bp.BlogDefinitionId);

        }
    }
}
