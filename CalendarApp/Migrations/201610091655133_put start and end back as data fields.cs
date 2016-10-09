namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class putstartandendbackasdatafields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "end", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "end");
            DropColumn("dbo.Events", "start");
        }
    }
}
