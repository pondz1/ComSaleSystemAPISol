namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProductGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductGroups",
                c => new
                    {
                        PrGrID = c.Int(nullable: false, identity: true),
                        PrGrPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PrGrID);
            
            AddColumn("dbo.Products", "ProImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProImage");
            DropTable("dbo.ProductGroups");
        }
    }
}
