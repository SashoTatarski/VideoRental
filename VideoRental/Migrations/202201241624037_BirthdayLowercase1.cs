namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class BirthdayLowercase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
        }
    }
}
