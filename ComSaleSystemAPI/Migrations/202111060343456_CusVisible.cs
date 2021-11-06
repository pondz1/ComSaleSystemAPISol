namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CusVisible : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Visible", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Visible");
        }
    }
}
