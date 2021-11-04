namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGID2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApproveLists", "PGID", c => c.Int(nullable: false));
            CreateIndex("dbo.ApproveLists", "PGID");
            AddForeignKey("dbo.ApproveLists", "PGID", "dbo.ProductGroups", "PGID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApproveLists", "PGID", "dbo.ProductGroups");
            DropIndex("dbo.ApproveLists", new[] { "PGID" });
            DropColumn("dbo.ApproveLists", "PGID");
        }
    }
}
