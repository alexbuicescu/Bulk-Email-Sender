namespace Itec_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSessionAttachments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessionAttachments", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.SessionAttachments", "AttachmentId", "dbo.Attachments");
            AddColumn("dbo.Attachments", "SessionId", c => c.Int(nullable: false));
            AddColumn("dbo.Attachments", "FullFileName", c => c.String(nullable: false, maxLength: 4000));
            AddForeignKey("dbo.Attachments", "SessionId", "dbo.Sessions", "Id", cascadeDelete: false);
            DropColumn("dbo.Attachments", "FileName");
            DropTable("dbo.SessionAttachments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SessionAttachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionId = c.Int(nullable: false),
                        AttachmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Attachments", "FileName", c => c.String(nullable: false, maxLength: 4000));
            DropForeignKey("dbo.Attachments", "SessionId", "dbo.Sessions");
            DropColumn("dbo.Attachments", "FullFileName");
            DropColumn("dbo.Attachments", "SessionId");
            AddForeignKey("dbo.SessionAttachments", "AttachmentId", "dbo.Attachments", "Id", cascadeDelete: false);
            AddForeignKey("dbo.SessionAttachments", "SessionId", "dbo.Sessions", "Id", cascadeDelete: false);
        }
    }
}
