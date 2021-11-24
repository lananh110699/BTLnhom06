namespace BTLnhom06.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_column_table_nhapkho : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhapKhoe", "ThanhTien", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhapKhoe", "ThanhTien");
        }
    }
}
