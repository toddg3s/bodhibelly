//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bodhibelly.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public Tag()
        {
            this.Recipes = new HashSet<Recipe>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public int tagtypeId { get; set; }
    
        public virtual TagType TagType { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
