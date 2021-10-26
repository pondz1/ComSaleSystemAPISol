namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CusFirstName = c.String(),
                        CusLastName = c.String(),
                        CusAddress = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmpDesignation = c.String(),
                        EmpAddress = c.String(),
                        EmpSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmpJoiningDate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProName = c.String(),
                        ProPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
