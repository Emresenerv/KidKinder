namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        LessonId = c.Int(nullable: false, identity: true),
                        LessonName = c.String(),
                        LessonDate = c.String(),
                        LessonDateTime = c.String(),
                    })
                .PrimaryKey(t => t.LessonId);
            
            DropTable("dbo.TrackingSystems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TrackingSystems",
                c => new
                    {
                        TrackingSystemId = c.Int(nullable: false, identity: true),
                        LessonName = c.String(),
                        LessonDate = c.String(),
                        LessonDateTime = c.String(),
                    })
                .PrimaryKey(t => t.TrackingSystemId);
            
            DropTable("dbo.Lessons");
        }
    }
}
