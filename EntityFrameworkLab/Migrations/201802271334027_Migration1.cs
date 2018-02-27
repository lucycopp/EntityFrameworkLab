namespace EntityFrameworkLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "Country");
        }
    }
}
