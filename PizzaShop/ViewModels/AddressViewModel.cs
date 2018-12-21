using System.ComponentModel.DataAnnotations;

namespace PizzaShop.ViewModels
{
    public class AddressViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Prompt = nameof(Street))]
        public string Street { get; set; }

        [Required]
        [Display(Prompt = nameof(Number))]
        public int Number { get; set; }

        [Required]
        [Display(Prompt = "Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Prompt = nameof(City))]
        public string City { get; set; }

        [Phone]
        [Display(Prompt = "Phone number")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Prompt = "example@email.com")]
        public string Email { get; set; }
    }
}