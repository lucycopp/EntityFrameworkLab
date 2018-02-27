namespace EntityFrameworkLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressIdentifier = c.Int(nullable: false, identity: true),
                        House_Name_or_Number = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        County = c.String(),
                        Postcode = c.String(),
                    })
                .PrimaryKey(t => t.AddressIdentifier);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Middle_Name = c.String(),
                        Last_Name = c.String(),
                        Date_of_Birth = c.DateTime(nullable: false),
                        Address_AddressIdentifier = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressIdentifier)
                .Index(t => t.Address_AddressIdentifier);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Address_AddressIdentifier", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "Address_AddressIdentifier" });
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
