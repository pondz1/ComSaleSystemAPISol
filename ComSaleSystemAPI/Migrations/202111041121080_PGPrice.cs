namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PGPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductGroups", "PGPrice", c => c.Decimal(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductGroups", "PGPrice", c => c.Int(nullable: false));
        }
    }
}
