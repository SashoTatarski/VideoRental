namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddBirthDays2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = CAST('1986-12-19' AS DATETIME) WHERE Id = 1");
        }

        public override void Down()
        {
        }
    }
}
