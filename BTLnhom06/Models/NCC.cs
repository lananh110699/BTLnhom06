using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("NCCs")]
    public class NCC
    {
        [Key]
        [Required(ErrorMessage = "Mã NCC không được để trống")]
        [Display(Name = "Mã NCC")]
        public String MaNCC { get; set; }

        [Required(ErrorMessage = "Tên NCC không được để trống")]
        [Display(Name = "Tên NCC")]
        public String TenNCC { get; set; }

        [Required(ErrorMessage = "Tên Hàng không được để trống")]
        [Display(Name = "Tên Hàng")]
        public String TenHang { get; set; }

        [Required(ErrorMessage = "Địa Chỉ không được để trống")]
        [Display(Name = "Địa Chỉ")]
        public String DiaChi { get; set; }

        [Required(ErrorMessage = "SĐT không được để trống")]
        public String SĐT { get; set; }

        
    }
}