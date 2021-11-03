namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type_Test2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSets", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProductSets", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.ProductSets", name: "Product_ProductId", newName: "ProductId");
            AlterColumn("dbo.ProductSets", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductSets", "ProductId");
            AddForeignKey("dbo.ProductSets", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSets", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductSets", new[] { "ProductId" });
            AlterColumn("dbo.ProductSets", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.ProductSets", name: "ProductId", newName: "Product_ProductId");
            CreateIndex("dbo.ProductSets", "Product_ProductId");
            AddForeignKey("dbo.ProductSets", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}
