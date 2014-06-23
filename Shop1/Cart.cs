using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop1
{
    public class Cart
    {
        List<ProductCount> products = new List<ProductCount>();
    

public List<ProductCount> Products
{
  get { return products; }
  set { products = value; }
}}
}