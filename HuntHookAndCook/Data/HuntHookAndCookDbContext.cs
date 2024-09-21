using HuntHookAndCook.Components.Pages.Recipe;
using HuntHookAndCook.Models;
using Microsoft.EntityFrameworkCore;

namespace HuntHookAndCook.Data
{
    public class HuntHookAndCookDbContext : DbContext
    {
        public HuntHookAndCookDbContext(DbContextOptions<HuntHookAndCookDbContext> options) : base(options) { }

        public DbSet<RecipeDefinition> Recipe { get; set; }
        public DbSet<CategoryDefinition> Category { get; set; }
        public DbSet<IngredientDefinition> Ingredient { get; set; }
        public DbSet<StepDefinition> Step { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeDefinition>()
                .HasMany(r => r.Ingredients)
                .WithOne(i => i.Recipe)
                .HasForeignKey(i => i.RecipeId);

            modelBuilder.Entity<RecipeDefinition>()
                .HasMany(r => r.Steps)
                .WithOne(s => s.Recipe)
                .HasForeignKey(s => s.RecipeId);

            modelBuilder.Entity<RecipeDefinition>()
                .HasOne(r => r.Category);
        }
    }
}
