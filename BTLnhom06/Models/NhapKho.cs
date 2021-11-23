using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("NhapKhoe")]
    public class NhapKho
    {
        [Key]
        [Required(ErrorMessage = "Mã Phiếu Nhập không được để trống")]
        [Display(Name = "Mã Phiếu Nhập")]
        public String MaPhieuNhap { get; set; }

        [Required(ErrorMessage = "Ngày Xuất không được để trống")]
        [Display(Name = "Ngày Nhập")]
        public String NgayNhap { get; set; }

        [Required(ErrorMessage = "Mã Hàng không được để trống")]
        [Display(Name = "Mã Hàng")]
        public String MaHang { get; set; }

        [Display(Name = "Số Lượng")]
        public String SoLuong { get; set; }

        [Display(Name = "Đơn Giá")]
        public String DonGia { get; set; }

        [Required(ErrorMessage = "Mã NV không được để trống")]
        [Display(Name = "Mã NV")]
        public String MaNV { get; set; }
    }
}