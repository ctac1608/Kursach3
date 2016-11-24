namespace Kursach3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CountCreatives", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "CreativesMedal");
            DropColumn("dbo.AspNetUsers", "CommentsMedal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CommentsMedal", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "CreativesMedal", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "CountCreatives");
        }
    }
}
