namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmpPosition", c => c.String());
            DropColumn("dbo.Employees", "EmpDesignation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmpDesignation", c => c.String());
            DropColumn("dbo.Employees", "EmpPosition");
        }
    }
}
