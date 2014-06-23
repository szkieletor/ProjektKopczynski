using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            string result = "Twoje zakupy: \n";
            foreach (ProductAmount p in c.Products)
            {
                result += p.Name + " Ilość:" + p.Count + "\n";
            }
            string x = Session["userName"].ToString();
            var query = from User u in context.Users
                        where u.Login == x
                        select u;
            User user = query.ToList()[0];
            try
            {
                MailMessage msg = new MailMessage();
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

                msg.Subject = "Zamowienie";
                msg.Body = result;
                msg.From = new MailAddress("sklepdotnet100@gmail.com");
                msg.To.Add(user.Email);
                msg.IsBodyHtml = true;
                client.Host = "smtp.gmail.com";
                System.Net.NetworkCredential basicauthenticationinfo = new System.Net.NetworkCredential("sklepdotnet100@gmail.com", "sklep100");
                client.Port = int.Parse("587");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicauthenticationinfo;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
            }
            catch (Exception ex)
            {
            }

            try
            {
                MailMessage msg = new MailMessage();
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                string text = "";

                text = "Imie: " + user.Name + " Nazwisko:" + user.LastName + " Miasto:" + user.City + " Adres:" + user.Address;
                text += " Produkty: ";
                Cart c1 = (Cart)Session["cart"];
                foreach (ProductAmount p in c1.Products)
                {
                    text += p.Name + " Ilość:" + p.Count + "\n";
                }

                msg.Subject = "Zamowienie";
                msg.Body = result;
                msg.From = new MailAddress("sklepdotnet100@gmail.com");
                msg.To.Add("sklepdotnet100@gmail.com");
                msg.IsBodyHtml = true;
                client.Host = "smtp.gmail.com";
                System.Net.NetworkCredential basicauthenticationinfo = new System.Net.NetworkCredential("sklepdotnet100@gmail.com", "sklep100");
                client.Port = int.Parse("587");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicauthenticationinfo;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
            }
            catch (Exception ex)
            {
            }
            Session["cart"] = null;

        }
    }
}