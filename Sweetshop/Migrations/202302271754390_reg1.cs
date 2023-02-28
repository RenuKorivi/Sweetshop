namespace Sweetshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddToCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bill = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddToCarts");
        }
    }
}
