namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductSets", "ProductAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductSets", "ProductAmount");
        }
    }
}
