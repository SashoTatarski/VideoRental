namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('A Love So Beautiful',3,2017-11-03, 2017-12-12,3)");
        }

        public override void Down()
        {
        }
    }
}
