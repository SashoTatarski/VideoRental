namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddBirthDays3 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = CAST('1986-12-18' AS DATE) WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
