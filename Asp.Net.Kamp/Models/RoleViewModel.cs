using System.ComponentModel.DataAnnotations;

namespace Asp.Net.Kamp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Rol adı giriniz")]
        public string Name { get; set; }
    }
}
