namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        public int Id { get; set; }

        public int recipeId { get; set; }

        public int? rating { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public DateTime reviewed { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
