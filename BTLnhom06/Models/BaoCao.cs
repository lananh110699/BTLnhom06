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
        public String DoanhThuTheoThang { get; set; }

        [Display(Name = "Doanh thu theo quý")]
        public String DoanhThuTheoQuy { get; set; }

        [Display(Name = "Đơn hàng trong ngày")]
        public String DonHangTrongNgay { get; set; }

        [Display(Name = "Đơn hàng trong tháng")]
        public String DonHangTrongThang { get; set; }
    }
}