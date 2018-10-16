using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Entity
    {
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }

        [MaxLength(100)]
        public string ModifiedBy { get; set; }
    }
}