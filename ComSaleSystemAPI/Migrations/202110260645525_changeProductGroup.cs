namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeProductGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductGroup_PrGrID", c => c.Int());
            CreateIndex("dbo.Products", "ProductGroup_PrGrID");
            AddForeignKey("dbo.Products", "ProductGroup_PrGrID", "dbo.ProductGroups", "PrGrID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductGroup_PrGrID", "dbo.ProductGroups");
            DropIndex("dbo.Products", new[] { "ProductGroup_PrGrID" });
            DropColumn("dbo.Products", "ProductGroup_PrGrID");
        }
    }
}
