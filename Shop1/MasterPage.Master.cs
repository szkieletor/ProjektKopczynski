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

        bool registered = false;
        DatabaseContext context = new DatabaseContext();
        List<ProductCategory> categories;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                registered = true;
                labelLoggedIn.Text = "Witaj " + Session["userName"];
            }
            if (registered)
            {
                PanelLogged.Visible = true;
                PanelNotLogged.Visible = false;
                int id = Convert.ToInt32(Session["userID"]);
                var query = from u in context.Users
                            where u.UserID == id
                            select u;
                User user = query.ToList()[0];
                if (user.IsAdmin) ButtonAdminPanel.Visible = true;
                else ButtonAdminPanel.Visible = false;
            }
            else
            {
                PanelLogged.Visible = false;
                PanelNotLogged.Visible = true;

            }
                if (!IsPostBack)
                {
                    if (Request.Cookies["userName"] != null)
                    {
                        TextBoxLogin.Text = Request.Cookies["userName"].Value;
                        if (Request.Cookies["password"] != null)
                        {
                            TextBoxPassword.Text = Request.Cookies["password"].Value;   
                        }
                    }

                    if (Application["counter"] == null)
                    {
                        Application["counter"] = 1;
                        LabelCounter.Text = "Liczba odwiedzin od startu serwera: " + Convert.ToInt32(Application["counter"]).ToString();

                    }
                    else
                    {
                        Application["counter"] = Convert.ToInt32(Application["counter"]) + 1;
                        LabelCounter.Text = "Liczba odwiedzin od startu serwera: " + Convert.ToInt32(Application["counter"]).ToString();
                    }

                    var query = context.Categories.OrderBy(c => c.Name);
                    categories = query.ToList();
                    Repeater1.DataSource = categories;
                    Repeater1.DataBind();

                    
                }

            
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            var query = from user in context.Users
                        where user.Name == TextBoxLogin.Text && user.Password == TextBoxPassword.Text
                        select user;

            if (query.ToList().Count == 1)
            {
                if (CheckBoxRemember.Checked)
                {
                    Response.Cookies["userName"].Value = TextBoxLogin.Text;
                    Response.Cookies["userName"].Expires = DateTime.Now.AddYears(1);
                    Response.Cookies["password"].Value = TextBoxPassword.Text;
                    Response.Cookies["password"].Expires = DateTime.Now.AddYears(1);
                }
                Session["userName"] = query.ToList()[0].Name;
                Session["userID"] = query.ToArray()[0].UserID;
                Response.Redirect("/About.aspx");
            }
            else
            {
                Session["userName"] = null;
                LabelInvalid.Visible = true;
            }

        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            registered = false;
            if (Response.Cookies["userName"] != null)
            {
                TextBoxLogin.Text = Response.Cookies["userName"].Value;
                if (Response.Cookies["password"] != null)
                {
                    TextBoxPassword.Text = Response.Cookies["password"].Value;
                    PanelLogged.Visible = false;
                    PanelNotLogged.Visible = true;
                }
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx?search=" + TextBoxSearch.Text);
        }

        protected void ButtonSetting_Click(object sender, EventArgs e)
        {
            Response.Redirect("Settings.aspx");
        }

        protected void ButtonAdminPanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdmProducts.aspx");
        }
    }
}