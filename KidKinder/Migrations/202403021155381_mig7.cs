namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        FamilyId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.FamilyId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        ClassRoom = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackingSystems");
            DropTable("dbo.Students");
            DropTable("dbo.Galleries");
            DropTable("dbo.Families");
        }
    }
}
