namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "GroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "GroupId", c => c.Int(nullable: false));
        }
    }
}
