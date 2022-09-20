namespace CoffeeOrderingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baristas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        HireDate = c.DateTime(),
                        Duty = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cashiers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        HireDate = c.DateTime(),
                        Duty = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        CustomerSurname = c.String(nullable: false, maxLength: 50),
                        CallNumber = c.String(),
                        Address = c.String(maxLength: 150),
                        Cashier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cashiers", t => t.Cashier_Id)
                .Index(t => t.Cashier_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        OrderPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderTime = c.Double(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CashierId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        OrderDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cashiers", t => t.CashierId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CashierId);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductionTime = c.Double(nullable: false),
                        AddedDate = c.DateTime(),
                        IsOnSale = c.Boolean(nullable: false),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PaymentType = c.Int(nullable: false),
                        PayableAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Coffees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductionTime = c.Double(nullable: false),
                        AddedDate = c.DateTime(),
                        IsOnSale = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Extras", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CashierId", "dbo.Cashiers");
            DropForeignKey("dbo.Customers", "Cashier_Id", "dbo.Cashiers");
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Extras", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "CashierId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "Cashier_Id" });
            DropTable("dbo.Coffees");
            DropTable("dbo.Payments");
            DropTable("dbo.Extras");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Cashiers");
            DropTable("dbo.Baristas");
        }
    }
}
