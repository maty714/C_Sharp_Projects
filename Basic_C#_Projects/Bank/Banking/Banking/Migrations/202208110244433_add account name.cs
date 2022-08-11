namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addaccountname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.userAccounts", "AccountName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.userAccounts", "AccountName");
        }
    }
}
