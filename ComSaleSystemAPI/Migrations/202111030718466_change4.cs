namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductGroups",
                c => new
                {
                    PGID = c.Int(nullable: false, identity: true),
                    PGName = c.String(nullable: false),
                    PGPrice = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.PGID);

            CreateTable(
                "dbo.ApproveLists",
                c => new
                    {
                        AppID = c.Int(nullable: false, identity: true),
                        AppStatus = c.Int(nullable: false),
                        PGID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppID)
                .ForeignKey("dbo.ProductGroups", t => t.PGID, cascadeDelete: true)
                .Index(t => t.PGID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApproveLists", "PGID", "dbo.ProductGroups");
            DropIndex("dbo.ApproveLists", new[] { "PGID" });
            DropTable("dbo.ApproveLists");
        }
    }
}
