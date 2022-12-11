using FruitStack.Infrastructure.Helpers;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Infrastructure.Services;
using FruitStack.Models.Responses;

namespace FruitStack.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IFruitService, FruitService>();

            services.AddScoped<ICacheManager<FruitResponse>, CacheManager<FruitResponse>>();

            return services;
        }
    }
}
