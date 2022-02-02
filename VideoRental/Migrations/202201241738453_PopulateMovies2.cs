namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Into The Wild',3,2007-11-03, 2022-03-24,3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Die Hard',3,2007-11-03, 2022-03-24,3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Trainspotting',3,2007-11-03, 2022-03-24,3)");
        }

        public override void Down()
        {
        }
    }
}
