using System.ComponentModel.DataAnnotations;

namespace WebShopper.Models
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Imie jest wymagane"), MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Nazwisko jest wymagane"), MaxLength(100)]
        public string LastName { get; set; } = "";

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = "";

        [Phone(ErrorMessage = "Format telefonu jest niepoprawny"), MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "hasła nie pasują do siebie")]
        public string ConfirmPassword { get; set; } = "";
    }
}
