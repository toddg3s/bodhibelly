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
    
    public partial class Ingredient
    {
        public int Id { get; set; }
        public Nullable<int> recipeId { get; set; }
        public string quantity { get; set; }
        public string unit { get; set; }
        public string name { get; set; }
    
        public virtual Recipe Recipe { get; set; }
    }
}
