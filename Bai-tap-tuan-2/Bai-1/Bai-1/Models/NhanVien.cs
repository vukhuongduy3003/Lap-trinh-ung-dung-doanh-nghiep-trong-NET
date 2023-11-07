using System;
using System.ComponentModel.DataAnnotations;

namespace Bai_1.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }

        [Required(ErrorMessage = "Họ tên là trường bắt buộc")]
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; }

        [Display(Name = "Điện Thoại")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string DienThoai { get; set; }

        [Display(Name = "Hệ Số Lương")]
        [Range(0, 10, ErrorMessage = "Hệ số lương phải từ 0 đến 10")]
        public decimal HeSoLuong { get; set; }

        [Display(Name = "Lương")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal Luong { get; set; }

        [Display(Name = "Tên Phòng")]
        public string TenPhong { get; set; }
    }
}