namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGID4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups");
            DropIndex("dbo.ProductSets", new[] { "ProductGroup_PGID" });
            RenameColumn(table: "dbo.ProductSets", name: "ProductGroup_PGID", newName: "PGID");
            AlterColumn("dbo.ProductSets", "PGID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductSets", "PGID");
            AddForeignKey("dbo.ProductSets", "PGID", "dbo.ProductGroups", "PGID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSets", "PGID", "dbo.ProductGroups");
            DropIndex("dbo.ProductSets", new[] { "PGID" });
            AlterColumn("dbo.ProductSets", "PGID", c => c.Int());
            RenameColumn(table: "dbo.ProductSets", name: "PGID", newName: "ProductGroup_PGID");
            CreateIndex("dbo.ProductSets", "ProductGroup_PGID");
            AddForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups", "PGID");
        }
    }
}
