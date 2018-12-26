namespace PizzaShop.Business.Models
{
    public class CartModel : Model
    {
        public int Id { get; set; }

        public PizzaModel Pizza { get; set; }

        public int Quantity { get; set; }
    }
}