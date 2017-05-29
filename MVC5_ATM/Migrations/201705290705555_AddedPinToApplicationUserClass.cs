namespace MVC5_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPinToApplicationUserClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Pin", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Pin");
        }
    }
}
