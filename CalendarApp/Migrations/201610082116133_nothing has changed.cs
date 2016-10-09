namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nothinghaschanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "date", c => c.String());
        }
    }
}
