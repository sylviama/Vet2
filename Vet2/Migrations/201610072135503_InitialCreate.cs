namespace Vet2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AnimalTypes", "AnimalTypeName", c => c.String(nullable: false));
            AlterColumn("dbo.Owners", "ownerFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Owners", "ownerLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Pets", "PetName", c => c.String(nullable: false));
            AlterColumn("dbo.Vets", "VetFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Vets", "VetLastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vets", "VetLastName", c => c.String());
            AlterColumn("dbo.Vets", "VetFirstName", c => c.String());
            AlterColumn("dbo.Pets", "PetName", c => c.String());
            AlterColumn("dbo.Owners", "ownerLastName", c => c.String());
            AlterColumn("dbo.Owners", "ownerFirstName", c => c.String());
            AlterColumn("dbo.AnimalTypes", "AnimalTypeName", c => c.String());
        }
    }
}
