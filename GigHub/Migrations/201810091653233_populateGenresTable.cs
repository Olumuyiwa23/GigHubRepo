namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Jazz') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Pop') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Blues') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Rock') ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genre WHERE Id IN (1,2,3,4)");
        }
    }
}
