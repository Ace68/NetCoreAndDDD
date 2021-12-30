using NetCoreMeetDDD.Modules.Weather.Shared.CustomTypes;

namespace NetCoreMeetDDD.Modules.Weather.Abstracts;

public interface IWeatherService
{
    Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync();
}