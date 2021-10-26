namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApproveList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApproveLists",
                c => new
                    {
                        AppID = c.Int(nullable: false, identity: true),
                        AppStatus = c.Int(nullable: false),
                        PrGrID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppID)
                .ForeignKey("dbo.ProductGroups", t => t.PrGrID, cascadeDelete: true)
                .Index(t => t.PrGrID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApproveLists", "PrGrID", "dbo.ProductGroups");
            DropIndex("dbo.ApproveLists", new[] { "PrGrID" });
            DropTable("dbo.ApproveLists");
        }
    }
}
