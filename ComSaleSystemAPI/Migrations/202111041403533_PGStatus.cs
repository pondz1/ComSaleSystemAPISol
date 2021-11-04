namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductGroups", "PGStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductGroups", "PGStatus");
        }
    }
}
