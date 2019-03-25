using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Customer : Entity
    {

        [Key]
        public int CustomerId { get; set; }

        // TODO: No data annotations in data layer
        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}