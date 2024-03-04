﻿namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Title");
        }
    }
}
