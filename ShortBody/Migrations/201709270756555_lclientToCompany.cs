namespace ShortBody.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lclientToCompany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Clients", new[] { "Company_CompanyId" });
            RenameColumn(table: "dbo.Clients", name: "Company_CompanyId", newName: "CompanyId");
            AlterColumn("dbo.Clients", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "CompanyId");
            AddForeignKey("dbo.Clients", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Clients", new[] { "CompanyId" });
            AlterColumn("dbo.Clients", "CompanyId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "CompanyId", newName: "Company_CompanyId");
            CreateIndex("dbo.Clients", "Company_CompanyId");
            AddForeignKey("dbo.Clients", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
    }
}
