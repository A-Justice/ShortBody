namespace ShortBody.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientInvoices",
                c => new
                    {
                        ClientInvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        PurchaseOrderNumber = c.Int(nullable: false),
                        ProjectSite = c.String(maxLength: 4000),
                        WayBillNumber = c.Double(nullable: false),
                        Description = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat_Nhil = c.String(maxLength: 4000),
                        Remarks = c.String(maxLength: 4000),
                        Status = c.String(maxLength: 4000),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientInvoiceId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        City = c.String(maxLength: 4000),
                        Requester = c.String(maxLength: 4000),
                        Phone = c.String(maxLength: 4000),
                        Email = c.String(maxLength: 4000),
                        ServiceWanted = c.String(maxLength: 4000),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.Quotations",
                c => new
                    {
                        QuotationId = c.Int(nullable: false, identity: true),
                        QuoteDate = c.DateTime(nullable: false),
                        ProjectSite = c.String(maxLength: 4000),
                        MachineNumber = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat_Nhil = c.String(maxLength: 4000),
                        Remarks = c.String(maxLength: 4000),
                        JobStatus = c.String(maxLength: 4000),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuotationId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Email = c.String(maxLength: 4000),
                        Phone = c.String(maxLength: 4000),
                        Adddress = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.CompanyAccountDetails",
                c => new
                    {
                        CompanyAccountDetailId = c.Int(nullable: false, identity: true),
                        AccountName = c.String(maxLength: 4000),
                        AccountNumber = c.String(maxLength: 4000),
                        BankBranch = c.String(maxLength: 4000),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyAccountDetailId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        OperationId = c.Int(nullable: false, identity: true),
                        OperationName = c.String(maxLength: 4000),
                        OperationDescription = c.String(maxLength: 4000),
                        EstimateAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OperationId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentVoucher = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CompanyName = c.String(maxLength: 4000),
                        ChequeNumber = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplierInvoices",
                c => new
                    {
                        SupplierInvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        PurchaseOrderNumber = c.Int(nullable: false),
                        ProjectSite = c.String(maxLength: 4000),
                        WayBillNumber = c.Double(nullable: false),
                        Description = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat_Nhil = c.String(maxLength: 4000),
                        Remarks = c.String(maxLength: 4000),
                        Status = c.String(maxLength: 4000),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierInvoiceId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Email = c.String(maxLength: 4000),
                        Phone = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierInvoices", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Operations", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyAccountDetails", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Clients", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Quotations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientInvoices", "ClientId", "dbo.Clients");
            DropIndex("dbo.SupplierInvoices", new[] { "SupplierId" });
            DropIndex("dbo.Operations", new[] { "CompanyId" });
            DropIndex("dbo.CompanyAccountDetails", new[] { "CompanyId" });
            DropIndex("dbo.Quotations", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "Company_CompanyId" });
            DropIndex("dbo.ClientInvoices", new[] { "ClientId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.SupplierInvoices");
            DropTable("dbo.Incomes");
            DropTable("dbo.Expenses");
            DropTable("dbo.Operations");
            DropTable("dbo.CompanyAccountDetails");
            DropTable("dbo.Companies");
            DropTable("dbo.Quotations");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientInvoices");
        }
    }
}
