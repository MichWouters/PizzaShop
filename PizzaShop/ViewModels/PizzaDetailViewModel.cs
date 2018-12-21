using System.ComponentModel.DataAnnotations;

namespace PizzaShop.ViewModels
{
    public class PizzaDetailViewModel
    {
        public int PizzaId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Range(3.99, 9.99)]
        public decimal Price { get; set; }

        [MinLength(2)]
        public string[] Ingredients { get; set; }

        public bool IsAvailable { get; set; }
    }
}