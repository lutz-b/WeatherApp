using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.DataServices
{
    class WeatherDataService
    {
        public static async Task<WeatherModel> GetWeatherFromService(string queryString)
        {
            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] == null)
                return null;

            var weather = new WeatherModel
            {
                Title = (string) results["name"],
                Temperature = (string) results["main"]["temp"] + " F",
                Wind = (string) results["wind"]["speed"] + " mph",
                Humidity = (string) results["main"]["humidity"] + " %",
                Visibility = (string) results["weather"][0]["main"]
            };

            var time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
            var sunset = time.AddSeconds((double)results["sys"]["sunset"]);
            weather.Sunrise = sunrise + " UTC";
            weather.Sunset = sunset + " UTC";

            return weather;
        }
    }
}
