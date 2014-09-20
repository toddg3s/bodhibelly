namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        public Tag()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public int tagtypeId { get; set; }

        public virtual TagType TagType { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
