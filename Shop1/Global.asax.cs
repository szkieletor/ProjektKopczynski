using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Shop1
{
    public class Global : System.Web.HttpApplication
    {
        public static string connectionString;
        DatabaseContext db = new DatabaseContext();
        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
            connectionString = db.Database.Connection.ConnectionString;
        }
    }
}