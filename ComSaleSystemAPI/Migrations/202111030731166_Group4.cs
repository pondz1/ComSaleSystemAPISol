namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProGroup_PGID", "dbo.ProductGroups");
            DropIndex("dbo.Products", new[] { "ProGroup_PGID" });
            DropColumn("dbo.Products", "ProGroup_PGID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProGroup_PGID", c => c.Int());
            CreateIndex("dbo.Products", "ProGroup_PGID");
            AddForeignKey("dbo.Products", "ProGroup_PGID", "dbo.ProductGroups", "PGID");
        }
    }
}
