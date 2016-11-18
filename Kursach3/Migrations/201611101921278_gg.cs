namespace Kursach3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        Position = c.Int(nullable: false),
                        CreativeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Creatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rank = c.Single(nullable: false),
                        Count = c.Int(nullable: false),
                        CreateData = c.DateTime(nullable: false),
                        RedactData = c.DateTime(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Creative_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Creatives", t => t.Creative_Id)
                .Index(t => t.Creative_Id);
            
            AddColumn("dbo.AspNetUsers", "AvatarUrl", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreativesMedal", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "CommentsMedal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Creative_Id", "dbo.Creatives");
            DropIndex("dbo.Tags", new[] { "Creative_Id" });
            DropColumn("dbo.AspNetUsers", "CommentsMedal");
            DropColumn("dbo.AspNetUsers", "CreativesMedal");
            DropColumn("dbo.AspNetUsers", "AvatarUrl");
            DropTable("dbo.Tags");
            DropTable("dbo.Creatives");
            DropTable("dbo.Chapters");
        }
    }
}
