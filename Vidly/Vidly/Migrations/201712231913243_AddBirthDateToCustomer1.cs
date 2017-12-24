namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
            DropColumn("dbo.Customers", "BirthDay");
            DropColumn("dbo.Customers", "BirthMonth");
            DropColumn("dbo.Customers", "BirthYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BirthYear", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "BirthMonth", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "BirthDay", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
