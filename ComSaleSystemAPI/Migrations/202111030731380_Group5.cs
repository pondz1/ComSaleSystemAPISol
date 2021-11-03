namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Group5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "GroupId", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "GroupId");
        }
    }
}
