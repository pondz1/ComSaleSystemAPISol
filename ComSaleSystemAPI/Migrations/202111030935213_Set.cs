namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Set : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductSets", "ProGroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductSets", "ProGroupId", c => c.Int(nullable: false));
        }
    }
}
