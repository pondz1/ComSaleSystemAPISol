namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGID6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSets", "PGID", "dbo.ProductGroups");
            DropIndex("dbo.ProductSets", new[] { "PGID" });
            RenameColumn(table: "dbo.ProductSets", name: "PGID", newName: "ProductGroup_PGID");
            AlterColumn("dbo.ProductSets", "ProductGroup_PGID", c => c.Int());
            CreateIndex("dbo.ProductSets", "ProductGroup_PGID");
            AddForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups", "PGID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSets", "ProductGroup_PGID", "dbo.ProductGroups");
            DropIndex("dbo.ProductSets", new[] { "ProductGroup_PGID" });
            AlterColumn("dbo.ProductSets", "ProductGroup_PGID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ProductSets", name: "ProductGroup_PGID", newName: "PGID");
            CreateIndex("dbo.ProductSets", "PGID");
            AddForeignKey("dbo.ProductSets", "PGID", "dbo.ProductGroups", "PGID", cascadeDelete: true);
        }
    }
}
