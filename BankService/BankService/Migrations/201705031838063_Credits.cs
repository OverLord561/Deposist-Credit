namespace BankService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Credits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        CreditID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.CreditID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Credits");
        }
    }
}
