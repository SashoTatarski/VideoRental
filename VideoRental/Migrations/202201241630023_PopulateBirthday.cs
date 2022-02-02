namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1986-12-19' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '2000-03-21' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
