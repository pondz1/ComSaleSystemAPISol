namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeID);
            
            AddColumn("dbo.Products", "TypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "TypeId");
            AddForeignKey("dbo.Products", "TypeId", "dbo.ProductTypes", "TypeID", cascadeDelete: true);
            DropColumn("dbo.Products", "ProType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "TypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "TypeId" });
            DropColumn("dbo.Products", "TypeId");
            DropTable("dbo.ProductTypes");
        }
    }
}
