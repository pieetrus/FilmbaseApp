namespace JakubPietrusLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Directors", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Directors", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Reviews", "Contest", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.UserLogins", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserLogins", "Password", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserLogins", "Password", c => c.String());
            AlterColumn("dbo.UserLogins", "UserName", c => c.String());
            AlterColumn("dbo.Reviews", "Contest", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
            AlterColumn("dbo.Directors", "LastName", c => c.String());
            AlterColumn("dbo.Directors", "FirstName", c => c.String());
        }
    }
}
