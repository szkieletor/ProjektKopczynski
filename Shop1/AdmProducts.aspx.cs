using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class AdmProducts : System.Web.UI.Page
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
                DropDownListChooseCategory.DataSource = context.Categories.ToList();
                DropDownListChooseCategory.DataTextField = "Name";
                DropDownListChooseCategory.DataValueField = "ProductCategoryID";
                DropDownListChooseCategory.DataBind();
                if (context.Categories.ToList().Count > 0)
                {
                    int id = Convert.ToInt32(context.Categories.ToList()[0].ProductCategoryID);
                    var query = from p in context.Products
                                where p.ProductCategory.ProductCategoryID == id
                                select p;
                    DropDownListChooseProduct.DataSource = query.ToList();
                    DropDownListChooseProduct.DataTextField = "Name";
                    DropDownListChooseProduct.DataValueField = "ProductID";
                    DropDownListChooseProduct.DataBind();
                }

            }
        }

        protected void ButtonRemoveCategory_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(DropDownListRemoveCategory.SelectedValue);
            var query = from c in context.Categories
                        where c.ProductCategoryID == id
                        select c;

            context.Categories.Remove(query.ToList()[0]);
            context.SaveChanges();
            DropDownListRemoveCategory.DataSource = context.Categories.ToList();
            DropDownListRemoveCategory.DataTextField = "Name";
            DropDownListRemoveCategory.DataValueField = "ProductCategoryID";
            DropDownListRemoveCategory.DataBind();
            DropDownListChooseCategory.DataSource = context.Categories.ToList();
            DropDownListChooseCategory.DataTextField = "Name";
            DropDownListChooseCategory.DataValueField = "ProductCategoryID";
            DropDownListChooseCategory.DataBind();
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
                DropDownListChooseCategory.DataSource = context.Categories.ToList();
                DropDownListChooseCategory.DataTextField = "Name";
                DropDownListChooseCategory.DataValueField = "ProductCategoryID";
                DropDownListChooseCategory.DataBind();
            }

        }

        protected void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void DropDownListChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownListChooseCategory.SelectedValue);
            var query = from p in context.Products
                        where p.ProductCategory.ProductCategoryID == id
                        select p;

            DropDownListChooseProduct.DataSource = query.ToList();
            DropDownListChooseProduct.DataTextField = "Name";
                DropDownListChooseProduct.DataValueField = "ProductID";
                DropDownListChooseProduct.DataBind();
        }

        protected void ButtonEditDelete_Click(object sender, EventArgs e)
        {
            if (RadioButtonListOpcje.SelectedIndex == 0) //Edycja
            {
                Response.Redirect("AddProduct.aspx?ProductID=" + DropDownListChooseProduct.SelectedValue);
            }
            else // Usuwanie
            {
                int id = Convert.ToInt32(DropDownListChooseProduct.SelectedValue);
                var query = from p in context.Products
                            where p.ProductID == id
                            select p;

                if (query.ToList().Count == 1) context.Products.Remove(query.ToList()[0]);
                context.SaveChanges();
                DropDownListChooseProduct.DataSource = query.ToList();
                DropDownListChooseProduct.DataTextField = "Name";
                DropDownListChooseProduct.DataValueField = "ProductID";
                DropDownListChooseProduct.DataBind();
            }
        }
    }
}