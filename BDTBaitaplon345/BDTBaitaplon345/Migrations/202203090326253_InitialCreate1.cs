namespace BDTBaitaplon345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiaoViens",
                c => new
                    {
                        MaGiaoVien = c.String(nullable: false, maxLength: 128),
                        TenGiaoVien = c.String(),
                        PhongBan = c.String(),
                        HocPhanPhuTrach = c.String(),
                    })
                .PrimaryKey(t => t.MaGiaoVien);
            
            AddColumn("dbo.Students", "GioiTinh", c => c.String());
            AddColumn("dbo.Students", "DiaChi", c => c.String());
            AddColumn("dbo.Students", "SDT", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Students", "SDT");
            DropColumn("dbo.Students", "DiaChi");
            DropColumn("dbo.Students", "GioiTinh");
            DropTable("dbo.GiaoViens");
        }
    }
}
