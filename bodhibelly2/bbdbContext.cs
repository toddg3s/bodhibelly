namespace bodhibelly2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bbdbContext : DbContext
    {
        public bbdbContext()
            : base("name=bbdbContext")
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagType> TagTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instruction>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.link)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Instructions)
                .WithRequired(e => e.Recipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Recipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Recipes)
                .Map(m => m.ToTable("RecipeTag").MapLeftKey("recipeId").MapRightKey("tagId"));

            modelBuilder.Entity<Review>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<TagType>()
                .HasMany(e => e.Tags)
                .WithRequired(e => e.TagType)
                .WillCascadeOnDelete(false);
        }
    }
}
