namespace DemoLabWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoSungQuanHeBangGhe_ChiTiet : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ChiTietHoaDons", "GheId");
            AddForeignKey("dbo.ChiTietHoaDons", "GheId", "dbo.Ghes", "GheId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietHoaDons", "GheId", "dbo.Ghes");
            DropIndex("dbo.ChiTietHoaDons", new[] { "GheId" });
        }
    }
}
