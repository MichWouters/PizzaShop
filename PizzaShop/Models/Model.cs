namespace PizzaShop.Models
{
    public abstract class Model
    {
        public virtual Model ConvertUnmappableValues()
        {
            return this;
        }
    }
}