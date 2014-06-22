using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop1.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductCount> ProductCounts { get; set; }
        public DbSet<History> Histories { get; set; }
    }
}