using System.ComponentModel.DataAnnotations;

namespace RegistrationWizard.DTOs
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "IsAgreed is required")]
        public bool IsAgreed { get; set; }
    }
}
