using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class UserViewModelLogin
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
