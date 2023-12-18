using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Login
    {
        public enum CLASSNAME
        {
            DHTI14A1CL, DHTI14A2CL
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên bắt buộc phải nhập")]
        [DisplayName("Họ tên")]
        [MaxLength(30)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu có 8 ký tự, tối đa 20 ký tự")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Nhập lại mật khẩu phải giống trường mật khẩu")]
        public string ReEnterPassword { get; set; }

        //[Range(18, 60, ErrorMessage = "Tuổi từ 18 đến 60 tuổi")]
        [ScaffoldColumn(false)]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public bool Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public CLASSNAME ClassName { get; set; }
    }
}