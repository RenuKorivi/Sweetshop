namespace Sweetshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddProducts", "ProductName", c => c.String());
            DropColumn("dbo.AddProducts", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddProducts", "Name", c => c.String());
            DropColumn("dbo.AddProducts", "ProductName");
        }
    }
}
