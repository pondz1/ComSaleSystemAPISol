namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductIBuyItems", "Date", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductIBuyItems", "Date");
        }
    }
}
