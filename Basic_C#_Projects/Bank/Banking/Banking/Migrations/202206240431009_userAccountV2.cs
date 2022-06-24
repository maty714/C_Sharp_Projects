namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userAccountV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.userAccounts",
                c => new
                    {
                        AccountId = c.String(nullable: false, maxLength: 128),
                        accountType = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AccountId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.userAccounts", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.userAccounts", new[] { "ApplicationUser_Id" });
            DropTable("dbo.userAccounts");
        }
    }
}
