using Shop1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop1
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            GetProductCategories().ForEach(b => context.Categories.Add(b));
            GetUsers().ForEach(b => context.Users.Add(b));
        }

        private static List<ProductCategory> GetProductCategories()
        {
            var productCategories = new List<ProductCategory>
            {
                new ProductCategory {
                    ProductCategoryID = 1,
                    Name = "Kategoria1",
                },
                new ProductCategory {
                    ProductCategoryID = 2,
                    Name = "Kategoria2",
                }
            };
            return productCategories;
        }

        private static List<User> GetUsers()
        {
            var users = new List<User> {
                new User {
                    UserID = 1,
                    Name = "Name1",
                    LastName = "LastName1",
                    Password = "Name1", 
                },
                new User {
                    UserID = 2,
                    Name = "test",
                    LastName = "LastName1",
                    Password = "test", 
                }

            };

            return users;
        }
    }
}