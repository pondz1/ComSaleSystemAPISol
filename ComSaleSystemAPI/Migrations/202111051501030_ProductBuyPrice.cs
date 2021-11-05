namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductBuyPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductIBuyItems", "BuyCurrentPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductIBuyItems", "BuyCurrentPrice");
        }
    }
}
