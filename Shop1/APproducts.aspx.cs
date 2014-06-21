using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListRemoveCategory.DataSource = context.Categories.ToList();
                DropDownListRemoveCategory.DataTextField = "Name";
                DropDownListRemoveCategory.DataValueField = "ProductCategoryID";
                DropDownListRemoveCategory.DataBind();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownListRemoveCategory.SelectedValue);
            var query = from cat in context.Categories
                        where cat.ProductCategoryID == id
                        select cat;
            List<ProductCategory> categories = query.ToList();
           context.Categories.Remove(categories[0]);
           context.SaveChanges();
           DropDownListRemoveCategory.DataSource = context.Categories.ToList();
           DropDownListRemoveCategory.DataTextField = "Name";
           DropDownListRemoveCategory.DataValueField = "ProductCategoryID";
           DropDownListRemoveCategory.DataBind();
           
        }

        protected void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            if (TextBoxAddCategory.Text.Length > 0)
            {
                ProductCategory category = new ProductCategory();
                category.Name = TextBoxAddCategory.Text;
                context.Categories.Add(category);
                context.SaveChanges();
                TextBoxAddCategory.Text = "";
                DropDownListRemoveCategory.DataSource = context.Categories.ToList();
                DropDownListRemoveCategory.DataTextField = "Name";
                DropDownListRemoveCategory.DataValueField = "ProductCategoryID";
                DropDownListRemoveCategory.DataBind();
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}