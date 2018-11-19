namespace PizzaShop.Models
{
    public abstract class Model
    {
        public virtual Model Convert()
        {
            return this;
        }
    }
}