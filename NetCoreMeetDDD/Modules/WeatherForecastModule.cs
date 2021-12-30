using NetCoreMeetDDD.Modules.Weather;
using NetCoreMeetDDD.Modules.Weather.Abstracts;

namespace NetCoreMeetDDD.Modules;

public sealed class WeatherForecastModule : IModule
{
    public IServiceCollection RegisterModule(IServiceCollection services)
    {
        services.AddWeatherModule();

        return services;
    }

    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/weatherforecast", async (IWeatherService weatherService) => 
                await weatherService.GetWeatherForecastAsync())
            .WithName("GetWeatherForecast")
            .WithTags("WeatherForecast");

        return endpoints;
    }
}