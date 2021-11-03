namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Set1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductSets", "ProId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductSets", "ProId", c => c.Int(nullable: false));
        }
    }
}
