namespace Roller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (10, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (11, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (12, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (13, 300, 12, 20)");

            //DropColumn("dbo.MembershipTypes", "MembershipName");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
        }
    }
}
