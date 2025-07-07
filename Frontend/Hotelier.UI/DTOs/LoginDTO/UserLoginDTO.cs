using System.ComponentModel.DataAnnotations;

namespace Hotelier.UI.DTOs.LoginDTO
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
