using System.ComponentModel.DataAnnotations;

namespace WebShopper.Models
{
    public class CheckoutDto
    {
        [Required(ErrorMessage = "Adres dostawy jest wymagany.")]
        [MaxLength(200)]
        public string DeliveryAddress { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
    }
}
