namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDay", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "BirthMonth", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "BirthYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthYear");
            DropColumn("dbo.Customers", "BirthMonth");
            DropColumn("dbo.Customers", "BirthDay");
        }
    }
}
