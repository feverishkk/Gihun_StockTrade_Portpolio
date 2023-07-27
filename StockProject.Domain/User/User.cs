using System.ComponentModel.DataAnnotations;

namespace StockTrade.Domain.User
{
    public class User
    {
        [Display(Name = "유저 ID")]
        [Required]
        public Guid UserId { get; set; }

        [Display(Name = "이름")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "비밀번호")]
        [Required]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "전화번호")]
        [Required]
        public string Mobile { get; set; } = string.Empty;

        [Display(Name = "주소")]
        [Required]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "우편번호")]
        [Required]
        public string PostCode { get; set; } = string.Empty;

        [Display(Name = "E-Mail")]
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "생일")]
        [Required]
        public DateTime Birthday { get; set; }

        [Display(Name = "확인유무")]
        [Required]
        public int IsConfirmed { get; set; }

        [Display(Name = "가입한 날짜")]
        [Required]
        public DateTime MemeberSince { get; set; }

        [Display(Name = "권한")]
        [Required]
        public int RoleId { get; set; }
    }
}
