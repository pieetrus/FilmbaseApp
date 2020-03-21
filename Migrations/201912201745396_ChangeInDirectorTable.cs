namespace JakubPietrusLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInDirectorTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Directors", "Name", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Directors", "FirstName");
            DropColumn("dbo.Directors", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Directors", "LastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Directors", "FirstName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Directors", "Name");
        }
    }
}
