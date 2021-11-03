namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductSets", "Product_ProductId", c => c.Int());
            AddColumn("dbo.ProductSets", "ProductGroup_PGID", c => c.Int());
            CreateIndex("dbo.ProductSets", "Product_ProductId");
            CreateIndex("dbo.ProductSets", "ProductGroup_PGID");
            AddForeignKey("dbo.ProductSets", "Product_ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups", "PGID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups");
            DropForeignKey("dbo.ProductSets", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProductSets", new[] { "ProductGroup_PGID" });
            DropIndex("dbo.ProductSets", new[] { "Product_ProductId" });
            DropColumn("dbo.ProductSets", "ProductGroup_PGID");
            DropColumn("dbo.ProductSets", "Product_ProductId");
        }
    }
}
