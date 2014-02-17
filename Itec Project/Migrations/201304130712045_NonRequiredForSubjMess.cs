namespace Itec_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NonRequiredForSubjMess : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SessionContacts", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.SessionContacts", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.SessionAttachments", "AttachmentId", "dbo.Attachments");
            DropForeignKey("dbo.SessionAttachments", "SessionId", "dbo.Sessions");
            DropTable("dbo.SessionContacts");
            DropTable("dbo.SessionAttachments");
            DropTable("dbo.Attachments");
            DropTable("dbo.Contacts");
            DropTable("dbo.Sessions");

            CreateTable(
                "dbo.Sessions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 800),
                    From = c.String(nullable: false, maxLength: 320),
                    Subject = c.String(nullable: true),
                    Message = c.String(nullable: true),
                    SmtpSettings_Address = c.String(nullable: false),
                    SmtpSettings_Port = c.Int(nullable: false),
                    SmtpSettings_User = c.String(),
                    SmtpSettings_Password = c.String(),
                    MailOptions_EmailsNumber = c.Int(nullable: false, defaultValue: 1),
                    MailOptions_MinTime = c.Int(nullable: false, defaultValue: 1),
                    MailOptions_MaxTime = c.Int(nullable: false, defaultValue: 3),
                    MailOptions_UseCounter = c.Boolean(nullable: false, defaultValue: true),
                    MailOptions_UseRandomSubject = c.Boolean(nullable: false, defaultValue: true),
                    MailOptions_UseRandomMessage = c.Boolean(nullable: false, defaultValue: true),
                    MailOptions_IsHtml = c.Boolean(nullable: false, defaultValue: false),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 800),
                    Email = c.String(nullable: false, maxLength: 320),
                    EmailsNumber = c.Int(nullable: false)
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);

            CreateTable(
                "dbo.Attachments",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OriginalFileName = c.String(nullable: false),
                    FileName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.SessionAttachments",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SessionId = c.Int(nullable: false),
                    AttachmentId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: false)
                .ForeignKey("dbo.Attachments", t => t.AttachmentId, cascadeDelete: false);

            CreateTable(
                "dbo.SessionContacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SessionId = c.Int(nullable: false),
                    ContactId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessions", t => t.SessionId, cascadeDelete: false)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: false);
        }

        public override void Down()
        {
            DropForeignKey("dbo.SessionContacts", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.SessionContacts", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.SessionAttachments", "AttachmentId", "dbo.Attachments");
            DropForeignKey("dbo.SessionAttachments", "SessionId", "dbo.Sessions");
            DropTable("dbo.SessionContacts");
            DropTable("dbo.SessionAttachments");
            DropTable("dbo.Attachments");
            DropTable("dbo.Contacts");
            DropTable("dbo.Sessions");
        }        
    }
}
