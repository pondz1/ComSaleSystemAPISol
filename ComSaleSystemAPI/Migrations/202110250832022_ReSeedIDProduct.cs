namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReSeedIDProduct : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('Products', RESEED, 1000)");
            Sql("DBCC CHECKIDENT ('Customers', RESEED, 1000)");
        }
        
        public override void Down()
        {
        }
    }
}
