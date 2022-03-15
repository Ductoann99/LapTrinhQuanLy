namespace BDTBaitaplon345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        RoleID = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.String(nullable: false, maxLength: 128),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            AlterColumn("dbo.Diems", "HocKi", c => c.Single(nullable: false));
            AlterColumn("dbo.Diems", "DiemA", c => c.Single(nullable: false));
            AlterColumn("dbo.Diems", "DiemB", c => c.Single(nullable: false));
            AlterColumn("dbo.Diems", "DiemC", c => c.Single(nullable: false));
            AlterColumn("dbo.Diems", "DiemTongKet", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Diems", "DiemTongKet", c => c.String());
            AlterColumn("dbo.Diems", "DiemC", c => c.String());
            AlterColumn("dbo.Diems", "DiemB", c => c.String());
            AlterColumn("dbo.Diems", "DiemA", c => c.String());
            AlterColumn("dbo.Diems", "HocKi", c => c.String());
            DropTable("dbo.Roles");
            DropTable("dbo.Accounts");
        }
    }
}
