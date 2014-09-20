namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        public Recipe()
        {
            Ingredients = new HashSet<Ingredient>();
            Instructions = new HashSet<Instruction>();
            Reviews = new HashSet<Review>();
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(500)]
        public string link { get; set; }

        [StringLength(500)]
        public string picture { get; set; }

        public DateTime? posted { get; set; }

        public double? avgrating { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public int? servings { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual ICollection<Instruction> Instructions { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
