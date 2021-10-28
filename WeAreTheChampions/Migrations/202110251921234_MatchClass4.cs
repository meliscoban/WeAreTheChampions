namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchClass4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Matches", "Team1Id");
            CreateIndex("dbo.Matches", "Team2Id");
            AddForeignKey("dbo.Matches", "Team1Id", "dbo.Teams", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Matches", "Team2Id", "dbo.Teams", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
        }
    }
}
