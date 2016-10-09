namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedeventIDfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "eventID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "eventID");
        }
    }
}
