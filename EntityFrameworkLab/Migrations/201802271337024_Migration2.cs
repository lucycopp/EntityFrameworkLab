namespace EntityFrameworkLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.People", "Middle_Name", "Middle_Names");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.People", "Middle_Names", "Middle_Name");
        }
    }
}
