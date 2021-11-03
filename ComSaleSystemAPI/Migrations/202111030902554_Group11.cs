namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductGroup_PGID", c => c.Int());
            CreateIndex("dbo.Products", "ProductGroup_PGID");
            AddForeignKey("dbo.Products", "ProductGroup_PGID", "dbo.ProductGroups", "PGID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductGroup_PGID", "dbo.ProductGroups");
            DropIndex("dbo.Products", new[] { "ProductGroup_PGID" });
            DropColumn("dbo.Products", "ProductGroup_PGID");
        }
    }
}
