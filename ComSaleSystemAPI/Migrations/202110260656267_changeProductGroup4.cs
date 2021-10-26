namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeProductGroup4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProductGroup_PrGrID", "dbo.ProductGroups");
            DropIndex("dbo.Products", new[] { "ProductGroup_PrGrID" });
            AddColumn("dbo.ProductGroups", "PrGrProduct", c => c.String());
            DropColumn("dbo.Products", "ProductGroup_PrGrID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductGroup_PrGrID", c => c.Int());
            DropColumn("dbo.ProductGroups", "PrGrProduct");
            CreateIndex("dbo.Products", "ProductGroup_PrGrID");
            AddForeignKey("dbo.Products", "ProductGroup_PrGrID", "dbo.ProductGroups", "PrGrID");
        }
    }
}
