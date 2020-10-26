namespace DataRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quanlity = c.Long(nullable: false),
                        Price = c.Long(nullable: false),
                        DisCount = c.Long(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Bill_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bill", t => t.Bill_Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .Index(t => t.Bill_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Long(nullable: false),
                        TotalAfterTax = c.Long(nullable: false),
                        State = c.Boolean(nullable: false),
                        Payment = c.Boolean(nullable: false),
                        VAT = c.Long(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Outlet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Outlet", t => t.Outlet_Id)
                .Index(t => t.Outlet_Id);
            
            CreateTable(
                "dbo.Outlet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Location = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Long(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillDetail", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Bill", "Outlet_Id", "dbo.Outlet");
            DropForeignKey("dbo.BillDetail", "Bill_Id", "dbo.Bill");
            DropIndex("dbo.Bill", new[] { "Outlet_Id" });
            DropIndex("dbo.BillDetail", new[] { "Product_Id" });
            DropIndex("dbo.BillDetail", new[] { "Bill_Id" });
            DropTable("dbo.Product");
            DropTable("dbo.Outlet");
            DropTable("dbo.Bill");
            DropTable("dbo.BillDetail");
        }
    }
}
