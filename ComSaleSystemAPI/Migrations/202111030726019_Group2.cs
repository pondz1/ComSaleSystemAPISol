namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "GroupId", c => c.Int(nullable: true));
            AddColumn("dbo.Products", "ProGroup_PGID", c => c.Int());
            CreateIndex("dbo.Products", "ProGroup_PGID");
            AddForeignKey("dbo.Products", "ProGroup_PGID", "dbo.ProductGroups", "PGID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProGroup_PGID", "dbo.ProductGroups");
            DropIndex("dbo.Products", new[] { "ProGroup_PGID" });
            DropColumn("dbo.Products", "ProGroup_PGID");
            DropColumn("dbo.Products", "GroupId");
        }
    }
}
