namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Movies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) VALUES ('Terminator', 1, '1984-10-26', '1984-11-01', 11)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) VALUES ('Die Hard', 1, '1988-07-15', '1988-08-01', 22)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) VALUES ('Toy Story', 3, '1995-11-22', '1995-12-01', 33)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) VALUES ('Titanic', 4, '1997-12-19', '1998-01-01', 44)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) VALUES ('The Hangover', 5, '2009-06-02', '2009-07-01', 55)");
        }

        public override void Down()
        {
        }
    }
}
