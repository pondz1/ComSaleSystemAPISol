namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGID1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApproveLists", "PGID", "dbo.ProductGroups");
            DropIndex("dbo.ApproveLists", new[] { "PGID" });
            DropColumn("dbo.ApproveLists", "PGID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApproveLists", "PGID", c => c.Int(nullable: false));
            CreateIndex("dbo.ApproveLists", "PGID");
            AddForeignKey("dbo.ApproveLists", "PGID", "dbo.ProductGroups", "PGID", cascadeDelete: true);
        }
    }
}
