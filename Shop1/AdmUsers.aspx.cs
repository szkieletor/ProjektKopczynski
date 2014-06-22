using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop1
{
    public partial class AdmUsers : System.Web.UI.Page
    {

        DatabaseContext context = new DatabaseContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                DropDownListChooseUser.DataSource = context.Users.ToList();
                DropDownListChooseUser.DataTextField = "Name";
                DropDownListChooseUser.DataValueField = "UserID";
                DropDownListChooseUser.DataBind();
            }
        }

        protected void ButtonPotwierdz_Click(object sender, EventArgs e)
        {
            switch (RadioButtonListOpcje.SelectedIndex)
            {
                case 0: //Blokuj
                    var query = from p in context.Users
                                where p.UserID == Convert.ToInt32(DropDownListChooseUser.SelectedValue)
                                select p;
                    query.ToList()[0].isBlocked = true;
                    break;
                case 1: //Odblokuj
                                        var query1 = from p in context.Users
                                where p.UserID == Convert.ToInt32(DropDownListChooseUser.SelectedValue)
                                select p;
                    query1.ToList()[0].isBlocked = false;
                    break;
                case 2: //Usun
                                        var query2 = from p in context.Users
                                where p.UserID == Convert.ToInt32(DropDownListChooseUser.SelectedValue)
                                select p;
                    query2.ToList()[0].isBlocked = true;
                    context.Users.Remove(query2.ToList()[0]);
                    break;
            }
        }



    }
}