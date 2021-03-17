using MD.Weather.Models;

namespace MD.Weather.Services
{
    public interface IWeatherService
    {
        WeatherForecast GetByCity(string city, string unit);
    }
}