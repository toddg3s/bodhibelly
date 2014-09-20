namespace bodhibelly2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagType")]
    public partial class TagType
    {
        public TagType()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
