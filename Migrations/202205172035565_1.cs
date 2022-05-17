namespace Online_Medicine_Shopping_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        totalCost = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.ProductsInBills",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.BillId })
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.BillId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Purpose = c.String(nullable: false),
                        type = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Cost = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        imgUrl = c.String(),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsInBills", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductsInBills", "BillId", "dbo.Bills");
            DropIndex("dbo.ProductsInBills", new[] { "BillId" });
            DropIndex("dbo.ProductsInBills", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductsInBills");
            DropTable("dbo.Bills");
        }
    }
}
