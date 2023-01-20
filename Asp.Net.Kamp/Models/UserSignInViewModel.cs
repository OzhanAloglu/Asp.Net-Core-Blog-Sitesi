using System.ComponentModel.DataAnnotations;

namespace Asp.Net.Kamp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string password { get; set; }
    }
}
