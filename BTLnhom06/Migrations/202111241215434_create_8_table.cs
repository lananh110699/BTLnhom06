namespace BTLnhom06.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_8_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaoCaos",
                c => new
                    {
                        DoanhThuTheoThang = c.String(nullable: false, maxLength: 128),
                        DoanhThuTheoQuy = c.String(),
                        DonHangTrongNgay = c.String(),
                        DonHangTrongThang = c.String(),
                    })
                .PrimaryKey(t => t.DoanhThuTheoThang);
            
            CreateTable(
                "dbo.DangNhaps",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 50),
                        MatKhau = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(nullable: false),
                        Size = c.String(nullable: false),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        TenKH = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        SĐT = c.String(nullable: false),
                        STK = c.String(nullable: false),
                        NganHang = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.NCCs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(nullable: false),
                        TenHang = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        SĐT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhapKhoe",
                c => new
                    {
                        MaPhieuNhap = c.String(nullable: false, maxLength: 128),
                        NgayNhap = c.String(nullable: false),
                        MaHang = c.String(nullable: false),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        ThanhTien = c.String(),
                        MaNV = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.NVKhos",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        SĐT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.XuatKhos",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 128),
                        NgayXuat = c.String(nullable: false),
                        MaHang = c.String(nullable: false),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        ThanhTien = c.String(),
                        MaNV = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.XuatKhos");
            DropTable("dbo.NVKhos");
            DropTable("dbo.NhapKhoe");
            DropTable("dbo.NCCs");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HangHoas");
            DropTable("dbo.DangNhaps");
            DropTable("dbo.BaoCaos");
        }
    }
}
