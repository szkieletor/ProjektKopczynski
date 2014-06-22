namespace Shop1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedOrderAndProductCount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Users", t => t.OrderID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.ProductCounts",
                c => new
                    {
                        ProductCountID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        History_OrderID = c.Int(),
                        product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductCountID)
                .ForeignKey("dbo.Orders", t => t.History_OrderID)
                .ForeignKey("dbo.Products", t => t.product_ProductID)
                .Index(t => t.History_OrderID)
                .Index(t => t.product_ProductID);
            
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderID", "dbo.Users");
            DropForeignKey("dbo.ProductCounts", "product_ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductCounts", "History_OrderID", "dbo.Orders");
            DropIndex("dbo.ProductCounts", new[] { "product_ProductID" });
            DropIndex("dbo.ProductCounts", new[] { "History_OrderID" });
            DropIndex("dbo.Orders", new[] { "OrderID" });
            DropColumn("dbo.Users", "IsAdmin");
            DropTable("dbo.ProductCounts");
            DropTable("dbo.Orders");
        }
    }
}
