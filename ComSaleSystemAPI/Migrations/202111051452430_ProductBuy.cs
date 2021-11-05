namespace ComSaleSystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductBuy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductBuys",
                c => new
                    {
                        ProductBuyID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        Coupon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductBuyID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.ProductIBuyItems",
                c => new
                    {
                        BuyItemID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        BuyAmount = c.Int(nullable: false),
                        ProductBuyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuyItemID)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: false)
                .ForeignKey("dbo.ProductBuys", t => t.ProductBuyID, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ProductBuyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductIBuyItems", "ProductBuyID", "dbo.ProductBuys");
            DropForeignKey("dbo.ProductIBuyItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductBuys", "CustomerID", "dbo.Customers");
            DropIndex("dbo.ProductIBuyItems", new[] { "ProductBuyID" });
            DropIndex("dbo.ProductIBuyItems", new[] { "ProductId" });
            DropIndex("dbo.ProductBuys", new[] { "CustomerID" });
            DropTable("dbo.ProductIBuyItems");
            DropTable("dbo.ProductBuys");
        }
    }
}
