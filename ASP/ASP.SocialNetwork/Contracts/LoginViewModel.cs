using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASP.SocialNetwork.Contracts
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Запомнить")]
        public bool RememberMe { get; set; }
        [Required]
        public string ReturnUrl { get; set; }

    }
}
