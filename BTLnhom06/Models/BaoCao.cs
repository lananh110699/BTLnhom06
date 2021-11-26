using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("BaoCaos")]
    public class BaoCao
    {
        [Key]
        [Display(Name = "Doanh thu theo tháng")]
        public string DoanhThuTheoThang { get; set; }

        [Display(Name = "Doanh thu theo quý")]
        public string DoanhThuTheoQuy { get; set; }

        [Display(Name = "Đơn hàng trong ngày")]
        public string DonHangTrongNgay { get; set; }

        [Display(Name = "Đơn hàng trong tháng")]
        public string DonHangTrongThang { get; set; }
    }
}