using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bodhibelly2
{
    public partial class Recipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(var db = new bbdbContext())
            {
                Thread.Sleep(10000);
                var recipe = (from r in db.Recipes select r).FirstOrDefault();
                lblName.Text = recipe.name;
            }
        }
    }
}