using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.DataServices;
using WeatherApp.Models;
using WeatherApp.Shared;

namespace WeatherApp.BusinessLogics
{
    public class WeatherBusinessLogic
    {
        public static async Task<WeatherModel> GetWeather(string zipCode)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
            {
                return new WeatherModel();
            }

            var url = string.Format(WeatherConstants.Url, WeatherConstants.ApiKey, WeatherConstants.RegionId, zipCode);
            var weather = await WeatherDataService.GetWeatherFromService(url);

            return weather;
        }

    }
}
