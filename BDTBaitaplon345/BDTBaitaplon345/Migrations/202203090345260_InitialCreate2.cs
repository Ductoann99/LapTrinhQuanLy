namespace BDTBaitaplon345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diems",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaSinhVien = c.String(),
                        HocKi = c.String(),
                        DiemA = c.String(),
                        DiemB = c.String(),
                        DiemC = c.String(),
                        DiemTongKet = c.String(),
                        MaHocPhan = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hocphans",
                c => new
                    {
                        MaHocPhan = c.String(nullable: false, maxLength: 128),
                        TenHocPhan = c.String(),
                        SoTinChi = c.String(),
                    })
                .PrimaryKey(t => t.MaHocPhan);
            
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        MaKhoa = c.String(nullable: false, maxLength: 128),
                        TenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.MaKhoa);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        TenLop = c.String(nullable: false, maxLength: 128),
                        MaLop = c.String(),
                        MaKhoa = c.String(),
                    })
                .PrimaryKey(t => t.TenLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lops");
            DropTable("dbo.Khoas");
            DropTable("dbo.Hocphans");
            DropTable("dbo.Diems");
        }
    }
}
