namespace PizzaShop.Business.Models
{
    public class PizzaDetailViewModel : Model
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public string[] Ingredients { get; set; }

        public bool IsAvailable { get; set; }
    }
}