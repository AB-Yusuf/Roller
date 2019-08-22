namespace Roller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingFormToDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "TypeOfMembership", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "TypeOfMembership");
        }
    }
}
