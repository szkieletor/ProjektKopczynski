using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class Settings : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["userID"]);
            var query = from u in context.Users
                        where u.UserID == id
                        select u;
            if (query.ToList().Count > 0)
            {
                User user = query.ToList()[0];
            TextBoxAddress.Text = user.Address;
            TextBoxEmail.Text = user.Email;
            TextBoxLastName.Text = user.LastName;
            TextBoxCity.Text = user.City;
            TextBoxName.Text = user.Name;

            }
        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            if (TextBoxOldPassword.Text.Length > 0)
            {
                if (TextBoxPassword.Text.Equals(TextBoxRepeatPassword.Text))
                {
                    int id = Convert.ToInt32(Session["userID"]);
                    var query = from u in context.Users
                                where u.UserID == id
                                select u;
                    User user = query.ToList()[0];
                    context.Users.Remove(user);
                    user.Password = TextBoxPassword.Text;
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(Session["userID"]);
                    var query = from u in context.Users
                                where u.UserID == id
                                select u;
                    User user = query.ToList()[0];

                    context.Users.Remove(user);
                                            user.Name = TextBoxName.Text;
                    user.Address = TextBoxAddress.Text;
                    user.City = TextBoxCity.Text;
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
        }
    }
}