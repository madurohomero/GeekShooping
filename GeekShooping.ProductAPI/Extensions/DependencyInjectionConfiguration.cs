using AutoMapper;
using GeekShooping.ProductAPI.Config;
using GeekShooping.ProductAPI.Model.Context;
using GeekShooping.ProductAPI.Repository;

namespace GeekShooping.ProductAPI.Extensions
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterService( this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
