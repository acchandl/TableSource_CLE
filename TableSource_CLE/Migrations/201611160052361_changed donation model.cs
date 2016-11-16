namespace TableSource_CLE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeddonationmodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Donations", "organizationName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Donations", "organizationAddress", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Donations", "organizationCity", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Donations", "organizationState", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Donations", "organizationZip", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Donations", "organizationPhone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Donations", "organizationPhone", c => c.String(nullable: false));
            AlterColumn("dbo.Donations", "organizationZip", c => c.Int(nullable: false));
            AlterColumn("dbo.Donations", "organizationState", c => c.String(nullable: false));
            AlterColumn("dbo.Donations", "organizationCity", c => c.String(nullable: false));
            AlterColumn("dbo.Donations", "organizationAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Donations", "organizationName", c => c.String(nullable: false));
        }
    }
}
