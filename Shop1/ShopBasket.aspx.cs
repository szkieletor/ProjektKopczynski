using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class ShopBasket : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cart c = (Cart)Session["cart"];
                if (c != null)
                {
                    DataList1.DataSource = c.Products;
                    DataList1.DataBind();
                    DropDownListProductList.DataSource = c.Products;
                    DropDownListProductList.DataTextField = "Name";
                    DropDownListProductList.DataValueField = "Name";
                    DropDownListProductList.DataBind();// Trzeba utworzyc nowa klase zamiast oproduct count bo nie robi sie saveChanges() i nie nadaje ID
                }
            }

        }

        protected void ButtonPotwierz_Click(object sender, EventArgs e)
        {
            if (TextBoxZmien.Text.Length > 0 && RadioButtonOpcje.SelectedIndex == 0)
            {
                Cart c = (Cart)Session["cart"];
                foreach (ProductAmount pa in c.Products)
                {
                    if (pa.Name == DropDownListProductList.SelectedValue)
                    {
                        pa.Count = Convert.ToInt32(TextBoxZmien.Text);
                    }
                }
                Session["cart"] = c;
            }
            else if (RadioButtonOpcje.SelectedIndex == 1)
            {
                Cart c = (Cart)Session["cart"];
                Cart newCart = new Cart();
                foreach (ProductAmount pa in c.Products)
                {
                    if (  !(pa.Name == DropDownListProductList.SelectedValue))
                    {
                        ProductAmount amount = new ProductAmount();
                        amount.Name = pa.Name;
                        amount.Count = pa.Count;
                        newCart.Products.Add(amount);
                    }
                }
                Session["cart"] = newCart;
            }
            DropDownListProductList.DataBind();

            Cart c1 = (Cart)Session["cart"];
            if (c1 != null)
            {
                DataList1.DataSource = c1.Products;
                DataList1.DataBind();
                
            }
            DataList1.DataBind();
        }

        protected void ButtonPrzejdz_Click(object sender, EventArgs e)
        {
            Cart c = (Cart)Session["cart"];
            Order order = new Order();

            foreach (ProductAmount pa in c.Products)
            {
                ProductCount pc = new ProductCount();
                Product product = new Product();
                product.Name = pa.Name;
                pc.Product = product;
                pc.Count = pa.Count;

                order.Add(pc);
                order.Date = DateTime.Now.ToString() ;
                User user = (User) Session["userName"];
                var query = from User u in context.Users
                            where u.Login == user.Login
                            select u;

                order.User = query.ToList()[0];
                context.Histories.Add(order);
                context.SaveChanges();
            }
        }
    }
}