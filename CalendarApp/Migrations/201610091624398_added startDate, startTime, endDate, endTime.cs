namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedstartDatestartTimeendDateendTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "startDate", c => c.String());
            AddColumn("dbo.Events", "startTime", c => c.String());
            AddColumn("dbo.Events", "endDate", c => c.String());
            AddColumn("dbo.Events", "endTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "endTime");
            DropColumn("dbo.Events", "endDate");
            DropColumn("dbo.Events", "startTime");
            DropColumn("dbo.Events", "startDate");
        }
    }
}
