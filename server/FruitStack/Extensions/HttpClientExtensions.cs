﻿using FruitStack.Models.Constans;
using FruitStack.Models.Settings;
using Microsoft.Extensions.Options;

namespace FruitStack.Extensions
{
    public static class HttpClientExtensions
    {
        public static IServiceCollection AddHttpFruityviceClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<FruityviceSettings>(configuration.GetSection(FruityviceConstans.Section));

            services.AddHttpClient(FruityviceConstans.Client, httpClient =>
            {
                var settings = services.BuildServiceProvider().GetRequiredService<IOptions<FruityviceSettings>>();

                httpClient.BaseAddress = new Uri(settings.Value.BaseUrl);

                //Add request headers
                //httpClient.DefaultRequestHeaders.Add(MonobankConstants.TokenHeader, settings.Value.PersonalToken);
            });
            return services;
        }

        public static IServiceCollection AddHttpUnsplashClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<UnsplashSettings>(configuration.GetSection(UnsplashConstans.Section));

            services.AddHttpClient(UnsplashConstans.Client, httpClient =>
            {
                var settings = services.BuildServiceProvider().GetRequiredService<IOptions<UnsplashSettings>>();

                httpClient.BaseAddress = new Uri(settings.Value.BaseUrl);

            });
            return services;
        }
    }
}
