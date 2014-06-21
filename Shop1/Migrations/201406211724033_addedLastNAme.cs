namespace Shop1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedLastNAme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastName", c => c.String());
            DropColumn("dbo.Users", "Nazwisko");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Nazwisko", c => c.String());
            DropColumn("dbo.Users", "LastName");
        }
    }
}
