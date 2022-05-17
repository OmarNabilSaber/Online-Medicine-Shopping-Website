namespace Online_Medicine_Shopping_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductsInBills", "BillId", "dbo.Bills");
            DropForeignKey("dbo.ProductsInBills", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductsInBills", new[] { "ProductId" });
            DropIndex("dbo.ProductsInBills", new[] { "BillId" });
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TotalCost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ProductsInOrders",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.OrderId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        VisaNumper = c.String(nullable: false, maxLength: 20),
                        Cvv = c.String(nullable: false, maxLength: 4),
                        Password = c.String(nullable: false, maxLength: 50),
                        FristName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 12),
                        Adress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Bills", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bills", "OrderId");
            AddForeignKey("dbo.Bills", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            DropTable("dbo.ProductsInBills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductsInBills",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.BillId });
            
            DropForeignKey("dbo.Bills", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProductsInOrders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductsInOrders", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductsInOrders", new[] { "OrderId" });
            DropIndex("dbo.ProductsInOrders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Bills", new[] { "OrderId" });
            DropColumn("dbo.Bills", "OrderId");
            DropTable("dbo.Users");
            DropTable("dbo.ProductsInOrders");
            DropTable("dbo.Orders");
            CreateIndex("dbo.ProductsInBills", "BillId");
            CreateIndex("dbo.ProductsInBills", "ProductId");
            AddForeignKey("dbo.ProductsInBills", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.ProductsInBills", "BillId", "dbo.Bills", "BillId", cascadeDelete: true);
        }
    }
}
