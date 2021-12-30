using Microsoft.Extensions.DependencyInjection;
using NetCoreMeetDDD.Modules.Weather.Abstracts;
using NetCoreMeetDDD.Modules.Weather.Concretes;

namespace NetCoreMeetDDD.Modules.Weather;

public static class WeatherHelper
{
    public static IServiceCollection AddWeatherModule(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();

        return services;
    }
}