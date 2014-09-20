namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        public int Id { get; set; }

        public int? recipeId { get; set; }

        public double quantity { get; set; }

        [StringLength(20)]
        public string unit { get; set; }

        [StringLength(300)]
        public string name { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
