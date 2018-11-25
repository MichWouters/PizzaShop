namespace PizzaShop.Business.Models
{
    public abstract class Model
    {
        public virtual Model ConvertUnmappableValues()
        {
            return this;
        }
    }
}