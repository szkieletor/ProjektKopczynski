using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}