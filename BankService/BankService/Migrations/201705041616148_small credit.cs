namespace BankService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallcredit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Credits", "nLink", c => c.String());
            DropColumn("dbo.Credits", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Credits", "Link", c => c.String());
            DropColumn("dbo.Credits", "nLink");
        }
    }
}
