namespace DemoLabWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoMoiDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHoaDons",
                c => new
                    {
                        ChiTietHoaDonId = c.Int(nullable: false, identity: true),
                        HoaDonId = c.Int(nullable: false),
                        GheId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChiTietHoaDonId)
                .ForeignKey("dbo.HoaDons", t => t.HoaDonId, cascadeDelete: true)
                .Index(t => t.HoaDonId);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoadonId = c.Int(nullable: false, identity: true),
                        KhachHangId = c.Int(nullable: false),
                        NgayDatVe = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HoadonId)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangId, cascadeDelete: true)
                .Index(t => t.KhachHangId);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangId = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangId);
            
            CreateTable(
                "dbo.Ghes",
                c => new
                    {
                        GheId = c.Int(nullable: false, identity: true),
                        TenGhe = c.String(),
                        HangGheId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GheId)
                .ForeignKey("dbo.HangGhes", t => t.HangGheId, cascadeDelete: true)
                .Index(t => t.HangGheId);
            
            CreateTable(
                "dbo.HangGhes",
                c => new
                    {
                        HangGheId = c.Int(nullable: false, identity: true),
                        GiaVe = c.Single(nullable: false),
                        TenHangGhe = c.String(),
                    })
                .PrimaryKey(t => t.HangGheId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ghes", "HangGheId", "dbo.HangGhes");
            DropForeignKey("dbo.HoaDons", "KhachHangId", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietHoaDons", "HoaDonId", "dbo.HoaDons");
            DropIndex("dbo.Ghes", new[] { "HangGheId" });
            DropIndex("dbo.HoaDons", new[] { "KhachHangId" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "HoaDonId" });
            DropTable("dbo.HangGhes");
            DropTable("dbo.Ghes");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.ChiTietHoaDons");
        }
    }
}
