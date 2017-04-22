namespace BankService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deposits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deposits",
                c => new
                    {
                        DepositID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Type = c.String(),
                        Partial = c.String(),
                    })
                .PrimaryKey(t => t.DepositID);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        RateID = c.Int(nullable: false, identity: true),
                        DepositID = c.Int(nullable: false),
                        Name = c.String(),
                        Percents = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RateID)
                .ForeignKey("dbo.Deposits", t => t.DepositID, cascadeDelete: true)
                .Index(t => t.DepositID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rates", "DepositID", "dbo.Deposits");
            DropIndex("dbo.Rates", new[] { "DepositID" });
            DropTable("dbo.Rates");
            DropTable("dbo.Deposits");
        }
    }
}
