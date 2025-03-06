using System.ComponentModel.DataAnnotations;

namespace WebShopper.Models
{
	public class PasswordDto
	{
		[Required(ErrorMessage = "podaj stare hasło"), MaxLength(100)]
		public string CurrentPassword { get; set; } = "";

		[Required(ErrorMessage = "podaj nowe hasło"), MaxLength(100)]
		public string NewPassword { get; set; } = "";

		[Required(ErrorMessage = "Powtórz hasło")]
		[Compare("NewPassword", ErrorMessage = "hasła nie pasują do siebie")]
		public string ConfirmPassword { get; set; } = "";
	}
}
