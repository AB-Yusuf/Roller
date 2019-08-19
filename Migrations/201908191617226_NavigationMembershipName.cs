namespace Roller.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavigationMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipName_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipName_Id");
            AddForeignKey("dbo.Customers", "MembershipName_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipName_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipName_Id" });
            DropColumn("dbo.Customers", "MembershipName_Id");
        }
    }
}
