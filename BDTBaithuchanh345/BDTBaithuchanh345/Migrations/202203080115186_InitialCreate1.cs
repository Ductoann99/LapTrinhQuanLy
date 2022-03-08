namespace BDTBaithuchanh345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        TenPerson = c.String(nullable: false, maxLength: 128),
                        PersonID = c.String(),
                    })
                .PrimaryKey(t => t.TenPerson);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}
