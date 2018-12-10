using AutoMapper;
using PizzaShop.Business.Models;

namespace PizzaShop.Converters
{
    public class PizzaViewModelConverter : ITypeConverter<PizzaModel, PizzaViewModel>
    {
        public PizzaViewModel Convert(PizzaModel source, PizzaViewModel destination, ResolutionContext context)
        {
            destination.Image = "../../Images/" + source.Image;

            return destination;
        }
    }
}
