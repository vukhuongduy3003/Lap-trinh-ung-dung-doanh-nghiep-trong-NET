using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bai_tap_tuan_3.Models
{
    //    Create: cho phép thêm thông tin sao cho Ngày sinh nhập trên<input type=”date”, giới tính nhập trên điều khiển radiobuton, Phòng ban chọn trong 1 danh sách đổ xuống, Lương không nhập được tính bằng công thức: Lương= hệ số lương * 1 800 000
    //-Lấy ra 2 nhân viên có lương cao nhất,
    //-Viết action tìm kiếm: view cho phép chọn giới tính trên 1 danh sách đổ xuống, sau đó kích vào nút submit sẽ hiển thị danh sách nhân viên có giới tính đã chọn
    //- Tìm tất cả các nhân viên có tuổi< 30 
    //- Tìm kiếm nhân viên của 1 phòng với tên phòng nhập trên danh sách đổ xuống
    public class NhanVien
    {
        public enum GENDER
        {
            FEMALE, MALE, OTHER
        }

        public enum DEPARTMENT
        {
            BaoVe, sale, NhanSu
        }

        [Key]
        [Required(ErrorMessage = "ID không được để trống")]
        [DisplayName("Mã nhân viên")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [DisplayName("Họ tên nhân viên")]
        public string Name { get; set; }

        [Required]
        public GENDER Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public DEPARTMENT Department { get; set; }

        [Required(ErrorMessage = "Hệ số lương không được để trống")]
        [Range(0, float.MaxValue, ErrorMessage = "Hệ số lương không được âm")]
        [DataType(DataType.Currency)]
        public float HeSoLuong { get; set; }

        [ScaffoldColumn(false)]
        public float Luong { get; set; }
    }
}