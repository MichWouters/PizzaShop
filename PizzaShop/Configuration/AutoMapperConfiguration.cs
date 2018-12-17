namespace PizzaShop.Configuration
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperPresentationProfile>();
                cfg.AddProfile<AutoMapperBusinessProfile>();
            });
        }
    }
}