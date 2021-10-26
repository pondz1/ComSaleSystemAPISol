namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReSeedID : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('Employees', RESEED, 1000)");
        }
        
        public override void Down()
        {
        }
    }
}
