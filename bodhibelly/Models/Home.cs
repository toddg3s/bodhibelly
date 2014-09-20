using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bodhibelly.Models
{
    public class Home
    {
        public IEnumerable<Recipe> FeaturedRecipes { get; set; }
    }
}