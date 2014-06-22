
using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class Register : System.Web.UI.Page
    {
        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAccept_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Password = TextBoxLogin.Text;
            user.Email = TextBoxEmail.Text;
            user.Name = TextBoxName.Text;
            user.LastName = TextBoxLastName.Text;
            user.City = TextBoxCity.Text;
            user.Address = TextBoxCity.Text;
            user.IsAdmin = false;
            context.Users.Add(user);
            context.SaveChanges();
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = CheckBoxAccept.Checked;
        }

        
    }
}