namespace Roller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (MembershipName) VALUES (Daily)");
            Sql("INSERT INTO MembershipTypes (MembershipName) VALUES (Monthly)");
            Sql("INSERT INTO MembershipTypes (MembershipName) VALUES (Quarterly)");
            Sql("INSERT INTO MembershipTypes (MembershipName) VALUES (Yearly)");

        }
        
        public override void Down()
        {
            
        }
    }
}
