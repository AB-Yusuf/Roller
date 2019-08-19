namespace Roller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscribetoNewsLetterToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SubscribeToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "SubscribeToNewsLetter");
        }
    }
}
