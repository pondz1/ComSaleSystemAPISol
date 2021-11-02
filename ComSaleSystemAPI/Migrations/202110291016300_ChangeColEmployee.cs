namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmpLastName", c => c.String());
            DropColumn("dbo.Employees", "EmpPosition");
            AddColumn("dbo.Employees", "EmpPosition", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmpPosition", c => c.String());
            DropColumn("dbo.Employees", "EmpLastName");
        }
    }
}
