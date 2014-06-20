namespace Shop1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        ProductCategory_ProductCategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategory_ProductCategoryID)
                .Index(t => t.ProductCategory_ProductCategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Nazwisko = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        City = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductCategory_ProductCategoryID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "ProductCategory_ProductCategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
        }
    }
}
