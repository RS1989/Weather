using MD.HttpService;
using MD.Weather.Models;
using MD.WeatherConverter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD.Weather.Services
{
    public class WeatherService: IWeatherService
    {
        private readonly IHttpService _httpService;
        private readonly ApiConfig _apiConfig;
        private readonly IConverterService _convertService;

        public WeatherService(IHttpService httpService, IConverterService convertService, ApiConfig apiConfig)
        {
            _httpService = httpService;
            _apiConfig = apiConfig;
            _convertService = convertService;
        }


        public WeatherForecast GetByCity(string city, string unit)
        {
            var result = new WeatherForecast();
            var param = new Dictionary<string, string> 
            {
                { _apiConfig.ParameterName[0], city },
                { _apiConfig.ParameterName[1], _apiConfig.Key}
            };
            var weatherData = _httpService.Get(param, _apiConfig.Url);
            if (string.IsNullOrWhiteSpace(weatherData))
                throw new Exception("Weather api not responed");

            var weather = JsonConvert.DeserializeObject<OpenWeather>(weatherData);
            var temp = _convertService.Get(unit, weather.Main.Temp);
            result.Temperature = temp;
            if (unit.ToLowerInvariant().Equals("c"))
            {
             
                result.Unit = "C";
            }
            else if (unit.ToLowerInvariant().Equals("f"))
            {
               
                result.Unit = "F";
            }
            else 
            {
                throw new Exception("not C or F unit");
            }
            return result;
        }
    }
}
