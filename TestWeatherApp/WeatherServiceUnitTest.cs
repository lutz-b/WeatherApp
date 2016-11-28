using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApp.BusinessLogics;
using WeatherApp.Models;

namespace TestWeatherApp
{
    [TestClass]
    public class WeatherServiceUnitTest
    {
        [TestMethod]
        public void TestBerlinZipCode()
        {
            var zip = "12351";

            var weather = WeatherBusinessLogic.GetWeather(zip).Result;

            Assert.IsNotNull(weather);
            Assert.AreEqual(weather.GetType(), typeof(WeatherModel));
            
        }
    }
}
