using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("NVKhos")]
    public class NVKho
    {
        [Key]
        [Required(ErrorMessage = "Mã NV không được để trống")]
        [Display(Name = "Mã NV")]
        public String MaNV { get; set; }

        [Required(ErrorMessage = "Tên NV không được để trống")]
        [Display(Name = "Tên NV")]
        public String TenNV { get; set; }

        [Required(ErrorMessage = "Địa Chỉ không được để trống")]
        [Display(Name = "Địa Chỉ")]
        public String DiaChi { get; set; }

        [Required(ErrorMessage = "SĐT không được để trống")]
        public String SĐT { get; set; }
    }
}