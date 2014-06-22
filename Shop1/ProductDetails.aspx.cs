using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        Product currentProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ProductID"]);

            var query = from p in context.Products
                        where p.ProductID == id
                        select p;

            Product product = query.ToList()[0];
            currentProduct = product;
            LabelName.Text = product.Name;
            LabelPrice.Text = "Cena: " + product.Price.ToString();
            LabelDescription.Text = product.Description;

        }

        protected void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null)
            {
                if (Session["cart"] != null) {
                    Cart cart = (Cart) Session["cart"];
                    ProductCount pc = new ProductCount();
                    pc.Product = currentProduct;
                    pc.Count = 1;
                    cart.Products.Add(pc);
                    Session["cart"] = cart;
                }
                else
                {
                    Cart cart = new Cart();
                    ProductCount pc = new ProductCount();
                    pc.Product = currentProduct;
                    pc.Count = 1;
                    cart.Products.Add(pc);
                    Session["cart"] = cart;
                }

            }
        }
    }
}