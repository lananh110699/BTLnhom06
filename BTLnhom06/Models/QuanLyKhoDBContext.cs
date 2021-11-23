using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTLnhom06.Models
{
    public partial class QuanLyKhoDBContext : DbContext
    {
        public QuanLyKhoDBContext()
            : base("name=QuanLyKhoDBContext")
        {
        }

        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<XuatKho> XuatKhos { get; set; }
        public virtual DbSet<NhapKho> NhapKhos { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NVKho> NVKhos { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
