namespace Itec_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSchedule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionId = c.Int(nullable: false),
                        StartOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: false);            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "SessionId", "dbo.Sessions");
            DropTable("dbo.Schedules");
        }
    }
}
