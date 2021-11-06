namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SumPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductBuys", "SumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductBuys", "SumPrice");
        }
    }
}
