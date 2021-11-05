namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductBuydecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductBuys", "Date", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductBuys", "Date", c => c.Int(nullable: false));
        }
    }
}
