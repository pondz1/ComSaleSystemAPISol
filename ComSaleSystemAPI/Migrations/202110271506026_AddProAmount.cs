namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProAmount");
        }
    }
}
