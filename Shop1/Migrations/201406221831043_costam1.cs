namespace Shop1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class costam1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "OrderID", "dbo.Users");
            DropForeignKey("dbo.ProductCounts", "History_OrderID", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "OrderID" });
            DropIndex("dbo.ProductCounts", new[] { "product_ProductID" });
            DropPrimaryKey("dbo.Orders");
            AddColumn("dbo.Orders", "Date", c => c.String());
            AddColumn("dbo.Orders", "User_UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", "OrderID");
            CreateIndex("dbo.Orders", "User_UserID");
            CreateIndex("dbo.ProductCounts", "Product_ProductID");
            AddForeignKey("dbo.Orders", "User_UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.ProductCounts", "History_OrderID", "dbo.Orders", "OrderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductCounts", "History_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "User_UserID", "dbo.Users");
            DropIndex("dbo.ProductCounts", new[] { "Product_ProductID" });
            DropIndex("dbo.Orders", new[] { "User_UserID" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "OrderID", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "User_UserID");
            DropColumn("dbo.Orders", "Date");
            AddPrimaryKey("dbo.Orders", "OrderID");
            CreateIndex("dbo.ProductCounts", "product_ProductID");
            CreateIndex("dbo.Orders", "OrderID");
            AddForeignKey("dbo.ProductCounts", "History_OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.Orders", "OrderID", "dbo.Users", "UserID");
        }
    }
}
