namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCar",
                c => new
                    {
                        carNo = c.Int(nullable: false, identity: true),
                        carName = c.String(),
                        carModel = c.String(),
                        carCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.carNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCar");
        }
    }
}
