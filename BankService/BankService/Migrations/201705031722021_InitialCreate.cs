namespace BankService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
            
            CreateTable(
                "dbo.UserCalculators",
                c => new
                    {
                        UserCalculatorID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        OperationName = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserCalculatorID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SecondName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCalculators", "UserID", "dbo.Users");
            DropForeignKey("dbo.Rates", "DepositID", "dbo.Deposits");
            DropIndex("dbo.UserCalculators", new[] { "UserID" });
            DropIndex("dbo.Rates", new[] { "DepositID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserCalculators");
            DropTable("dbo.Rates");
            DropTable("dbo.Deposits");
        }
    }
}
