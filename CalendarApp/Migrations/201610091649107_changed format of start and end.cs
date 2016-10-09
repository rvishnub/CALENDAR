namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedformatofstartandend : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "start");
            DropColumn("dbo.Events", "end");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "end", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "start", c => c.DateTime(nullable: false));
        }
    }
}
