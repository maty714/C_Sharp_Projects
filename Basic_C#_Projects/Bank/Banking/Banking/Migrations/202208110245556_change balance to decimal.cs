namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changebalancetodecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.userAccounts", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.userAccounts", "Balance", c => c.Int(nullable: false));
        }
    }
}
