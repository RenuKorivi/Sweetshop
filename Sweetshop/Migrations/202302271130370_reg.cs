namespace Sweetshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "City", c => c.String());
            AddColumn("dbo.Registrations", "Address", c => c.String());
            AddColumn("dbo.Registrations", "ContactNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "ContactNumber");
            DropColumn("dbo.Registrations", "Address");
            DropColumn("dbo.Registrations", "City");
        }
    }
}
