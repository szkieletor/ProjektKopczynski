﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class ProductCount
    {
        public int ProductCountID { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }

        public virtual Order History { get; set; }
    }
}