namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetupSomeMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");

            Sql("INSERT INTO Movies( Id, Name, Genre, ReleaseDate, AddedDate, NumberInStock) VALUES (1, 'Hangover', 'Comedy', '21.02.2001', '14.05.2001', 7)");
            Sql("INSERT INTO Movies( Id, Name, Genre, ReleaseDate, AddedDate, NumberInStock) VALUES (2, 'Die Hard', 'Action', '05.09.2003', '03.12.2003', 6)");
            Sql("INSERT INTO Movies( Id, Name, Genre, ReleaseDate, AddedDate, NumberInStock) VALUES (3, 'The Terminator', 'Action', '16.07.1997', '02.07.2002', 11)");
            Sql("INSERT INTO Movies( Id, Name, Genre, ReleaseDate, AddedDate, NumberInStock) VALUES (4, 'Toy Story', 'Family', '05.06.1997', '03.11.2000', 8)");
            Sql("INSERT INTO Movies( Id, Name, Genre, ReleaseDate, AddedDate, NumberInStock) VALUES (5, 'Titanic', 'Romance', '12.07.1999', '17.01.2001', 4)");

            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {

        }
    }
}
