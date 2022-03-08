namespace BDTBaithuchanh345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        TenStudent = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(),
                    })
                .PrimaryKey(t => t.TenStudent);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
