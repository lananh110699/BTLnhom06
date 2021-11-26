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
        public string MaNV { get; set; }

        [Required(ErrorMessage = "Tên NV không được để trống")]
        [Display(Name = "Tên NV")]
        public string TenNV { get; set; }

        [Required(ErrorMessage = "Địa Chỉ không được để trống")]
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "SĐT không được để trống")]
        public string SĐT { get; set; }
        public ICollection<XuatKho> XuatKhos { get; set; }
    }
}