using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Shared
{
    public static class WeatherConstants
    {
        public const string ApiKey = "7708ac2ad172df19644c762c9f54814e";
        public const string RegionId = "de-De";
        public const string Url = "http://api.openweathermap.org/data/2.5/weather?zip={2},{1}&appid={0}&units=imperial";

    }
}
