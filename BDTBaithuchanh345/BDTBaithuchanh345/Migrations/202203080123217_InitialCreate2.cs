namespace BDTBaithuchanh345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        NameEmployee = c.String(nullable: false, maxLength: 128),
                        Employees = c.String(),
                    })
                .PrimaryKey(t => t.NameEmployee);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
