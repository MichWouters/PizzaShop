using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Customer : Entity
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(8, 99)]
        public int Age { get; set; }

        public virtual Gender Gender { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string ZIP { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2,
    }
}