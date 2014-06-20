using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        DatabaseContext context = new DatabaseContext();
        List<ProductCategory> categories;
        protected void Page_Load(object sender, EventArgs e)
        {
                var query = context.Categories.OrderBy(c => c.Name);
                categories = query.ToList();
                Repeater1.DataSource = categories;
                Repeater1.DataBind();
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}