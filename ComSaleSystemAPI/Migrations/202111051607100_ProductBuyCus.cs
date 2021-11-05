namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductBuyCus : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.ProductBuys", "CustomerID", c => c.Int(cascadeDelete: true));
        }
        
        public override void Down()
        {
        }
    }
}
