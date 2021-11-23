using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLnhom06.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        [Required(ErrorMessage = "Mã Hàng không được để trống")]
        [Display(Name = "Mã Hàng")]
        public String MaHang { get; set; }

        [Required(ErrorMessage = "Tên Hàng không được để trống")]
        [Display(Name = "Tên Hàng")]
        public String TenHang { get; set; }

        [Required(ErrorMessage = "size không được để trống")]
        public String Size { get; set; }

        [Display(Name = "Số Lượng")]
        public String SoLuong { get; set; }

        [Display(Name = "Đơn Giá")]
        public String DonGia { get; set; }


        [Display(Name = "Thành Tiền")]
        public String ThanhTien { get; set; }
    }
}