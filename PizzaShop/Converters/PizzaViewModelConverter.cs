using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.ViewModels;
using System.Linq;

namespace PizzaShop.Converters
{
    public class PizzaViewModelConverter : ITypeConverter<PizzaModel, PizzaDetailViewModel>
    {
        public PizzaDetailViewModel Convert(PizzaModel source, PizzaDetailViewModel destination, ResolutionContext context)
        {
            destination.Description = source.Description;
            destination.Ingredients = source.Ingredients.Select(x => x.Name).ToArray();
            destination.Name = source.Name;
            destination.PizzaId = source.PizzaId;
            destination.Price = source.Price;
            destination.Image = "../../Images/" + source.Image;

            return destination;
        }
    }
}