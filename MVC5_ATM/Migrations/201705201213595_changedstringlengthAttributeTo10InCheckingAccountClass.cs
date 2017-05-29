namespace MVC5_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedstringlengthAttributeTo10InCheckingAccountClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false, maxLength: 15, unicode: false));
        }
    }
}
