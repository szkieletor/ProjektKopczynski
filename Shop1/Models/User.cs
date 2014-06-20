using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
       
    }
}