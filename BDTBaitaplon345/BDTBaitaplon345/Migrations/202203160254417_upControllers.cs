namespace BDTBaitaplon345.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upControllers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Diems", "NamHoc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Diems", "NamHoc");
        }
    }
}
