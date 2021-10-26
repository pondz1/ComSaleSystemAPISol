namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProBrand", c => c.String());
            AddColumn("dbo.Products", "ProModel", c => c.String());
            AddColumn("dbo.Products", "ProDetail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProDetail");
            DropColumn("dbo.Products", "ProModel");
            DropColumn("dbo.Products", "ProBrand");
        }
    }
}
