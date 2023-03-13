namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarDescriptionadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblCar", "carDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblCar", "carDescription");
        }
    }
}
