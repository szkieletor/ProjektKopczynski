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
            User user = query.ToList()[0];
            TextBoxAddress.Text = user.Address;
            TextBoxEmail.Text = user.Email;
        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {

        }
    }
}