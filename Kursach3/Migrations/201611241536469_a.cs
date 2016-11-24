namespace Kursach3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CountCreatives", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Ban", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "CreativesMedal");
            DropColumn("dbo.AspNetUsers", "CommentsMedal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CommentsMedal", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "CreativesMedal", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Ban");
            DropColumn("dbo.AspNetUsers", "CountCreatives");
        }
    }
}
