namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetOneBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '19.06.1996' WHERE Id = 1");
        }
        
        public override void Down()
        {

        }
    }
}
