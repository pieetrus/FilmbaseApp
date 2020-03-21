namespace JakubPietrusLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDirectorAndGenreRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Director_Id", "dbo.Directors");
            DropForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Reviews", "UserLogin_Id", "dbo.UserLogins");
            DropIndex("dbo.Movies", new[] { "Director_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Reviews", new[] { "UserLogin_Id" });
            DropIndex("dbo.Reviews", new[] { "Movie_Id" });
            RenameColumn(table: "dbo.Movies", name: "Director_Id", newName: "DirectorId");
            RenameColumn(table: "dbo.Reviews", name: "Movie_Id", newName: "MovieId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.Reviews", name: "UserLogin_Id", newName: "UserLoginId");
            AlterColumn("dbo.Movies", "DirectorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "UserLoginId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "DirectorId");
            CreateIndex("dbo.Movies", "GenreId");
            CreateIndex("dbo.Reviews", "UserLoginId");
            CreateIndex("dbo.Reviews", "MovieId");
            AddForeignKey("dbo.Movies", "DirectorId", "dbo.Directors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "UserLoginId", "dbo.UserLogins", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "UserLoginId", "dbo.UserLogins");
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Movies", "DirectorId", "dbo.Directors");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            DropIndex("dbo.Reviews", new[] { "UserLoginId" });
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropIndex("dbo.Movies", new[] { "DirectorId" });
            AlterColumn("dbo.Reviews", "MovieId", c => c.Int());
            AlterColumn("dbo.Reviews", "UserLoginId", c => c.Int());
            AlterColumn("dbo.Movies", "GenreId", c => c.Int());
            AlterColumn("dbo.Movies", "DirectorId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "UserLoginId", newName: "UserLogin_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            RenameColumn(table: "dbo.Reviews", name: "MovieId", newName: "Movie_Id");
            RenameColumn(table: "dbo.Movies", name: "DirectorId", newName: "Director_Id");
            CreateIndex("dbo.Reviews", "Movie_Id");
            CreateIndex("dbo.Reviews", "UserLogin_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            CreateIndex("dbo.Movies", "Director_Id");
            AddForeignKey("dbo.Reviews", "UserLogin_Id", "dbo.UserLogins", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Reviews", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Movies", "Director_Id", "dbo.Directors", "Id");
        }
    }
}
