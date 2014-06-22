using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class History
    {
        public int HistoryID { get; set; }
        public virtual User User { get; set; }
        public virtual List<ProductCount> ProductCounter { get; set; }
    }
}