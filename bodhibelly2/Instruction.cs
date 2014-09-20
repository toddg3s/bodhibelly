namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Instruction")]
    public partial class Instruction
    {
        public int Id { get; set; }

        public int recipeId { get; set; }

        [Required]
        [StringLength(20)]
        public string step { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
