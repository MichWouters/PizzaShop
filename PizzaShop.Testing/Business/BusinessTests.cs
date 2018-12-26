using AutoMapper;
using PizzaShop.Configuration;

namespace PizzaShop.Testing.Business
{
    public class BusinessTests
    {
        protected BusinessTests()
        {
            // Initialize AutoMapper
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperModelProfile>());
        }
    }
}