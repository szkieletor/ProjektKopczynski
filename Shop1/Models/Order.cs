using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [Required]
        public virtual User User { get; set; }
        
        public virtual List<ProductCount> ProductCounter { get; set; }
    }
}