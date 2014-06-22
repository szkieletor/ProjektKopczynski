namespace Shop1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Login", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Login");
        }
    }
}
