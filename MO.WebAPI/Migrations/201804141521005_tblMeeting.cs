namespace MO.WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblMeeting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblMeetings",
                c => new
                    {
                        MeetingID = c.Int(nullable: false, identity: true),
                        MeetingTopic = c.String(nullable: false, maxLength: 50),
                        MeetingDate = c.DateTime(nullable: false),
                        StartTime = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        EndTime = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        Katılımcılar = c.String(nullable: false, storeType: "ntext"),
                    })
                .PrimaryKey(t => t.MeetingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblMeetings");
        }
    }
}
