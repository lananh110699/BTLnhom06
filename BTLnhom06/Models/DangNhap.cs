using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("DangNhaps")]
    public class DangNhap
    {
        [Key]
        [Required(ErrorMessage = "Tên Đăng Nhập không được để trống")]
        [StringLength(50)]
        [Display(Name = "Tên Đăng Nhập")]
        public string TenDangNhap { get; set; }

        [Required(ErrorMessage = "Mật Khẩu không được để trống")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }
    }
}