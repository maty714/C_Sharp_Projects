namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBalance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.userAccounts", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.userAccounts", "Balance");
        }
    }
}
