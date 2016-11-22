namespace Kursach3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qqq : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tags", "Creative_Id", "dbo.Creatives");
            DropIndex("dbo.Tags", new[] { "Creative_Id" });
            DropColumn("dbo.Tags", "Creative_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "Creative_Id", c => c.Int());
            CreateIndex("dbo.Tags", "Creative_Id");
            AddForeignKey("dbo.Tags", "Creative_Id", "dbo.Creatives", "Id");
        }
    }
}
