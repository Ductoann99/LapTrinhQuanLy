namespace BDTBaitaplon345.Migrations
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
                        TenSinhVien = c.String(nullable: false, maxLength: 128),
                        MaSinhvien = c.String(),
                    })
                .PrimaryKey(t => t.TenSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
