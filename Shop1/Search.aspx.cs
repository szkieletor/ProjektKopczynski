using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class Search : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string searchString = Request.QueryString["search"];

            var query = from p in context.Products
                        where p.Name.Contains(searchString)
                        select p;

            DataList1.DataSource = query.ToList();
            DataList1.DataBind();

            if (query.ToList().Count > 0)
            {
                LabelNoResults.Visible = false;
            }
        }
    }
}