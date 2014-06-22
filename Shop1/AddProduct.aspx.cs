using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class AddProduct : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        Product editedProduct;

        public Product EditedProduct
        {
            get { return editedProduct; }
            set { editedProduct = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListCategory.DataSource = context.Categories.ToList();
                DropDownListCategory.DataTextField = "Name";
                DropDownListCategory.DataValueField = "ProductCategoryID";
                DropDownListCategory.DataBind();
                if (Request.QueryString["ProductID"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["ProductID"]);

                    var query = from p in context.Products
                                where p.ProductID == id
                                select p;

                    if (query.ToList().Count == 1) {
                        editedProduct = (Product)query.ToList()[0];
                        TextBoxName.Text = editedProduct.Name;
                        TextBoxPrice.Text = editedProduct.Price.ToString();
                        TextBoxDescription.Text = editedProduct.Description;
                    }

                }
            }




        }

        public override void Dispose()
        {
            base.Dispose();

        }
        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownListCategory.SelectedValue);
            Product product = new Product();
            product.Name = TextBoxName.Text;
            product.Price = Convert.ToInt32(TextBoxPrice.Text);
            product.Description = TextBoxDescription.Text;
            //product.Image = ImageToByte(Image1);
            var query = from cat in context.Categories
                        where cat.ProductCategoryID == id
                        select cat;
            product.ProductCategory = query.ToList()[0];
            context.Products.Add(product);
            if (EditedProduct != null)
            {
                context.Products.Remove(editedProduct);
            }
            context.SaveChanges();
            Response.Redirect("ProductList.aspx?ProductCategoryID=" + product.ProductCategory.ProductCategoryID);
   
        }

        public static byte[] ImageToByte(System.Web.UI.WebControls.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}