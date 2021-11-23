using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [Required(ErrorMessage = "Mã khách hàng không được để trống")]
        [Display(Name = "Mã Khách Hàng")]
        public String MaKH { get; set; }

        [Required(ErrorMessage = "Tên Khách Hàng không được để trống")]
        [Display(Name = "Tên Khách Hàng")]
        public String TenKH { get; set; }

        [Required(ErrorMessage = "Địa Chỉ không được để trống")]
        [Display(Name = "Địa Chỉ")]
        public String DiaChi { get; set; }

        [Required(ErrorMessage = "SĐT không được để trống")]
        public String SĐT { get; set; }

        [Required(ErrorMessage = "Số tài khoản không được để trống")]
        [Display(Name = "Số tài khoản")]
        public String STK { get; set; }

        [Required(ErrorMessage = "Ngân Hàng không được để trống")]
        [Display(Name = "Ngân Hàng")]
        public String NganHang { get; set; }
    }
}