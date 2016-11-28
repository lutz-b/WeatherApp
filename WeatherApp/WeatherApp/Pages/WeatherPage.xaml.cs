using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessLogics;
using WeatherApp.Models;
using Xamarin.Forms;

namespace WeatherApp.Pages
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Sample Weather App";

            GetWeatherButton.Clicked += OnGetWeatherButtonClicked;

            this.BindingContext = new WeatherModel();
        }

        private async void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
            var zip = "12351";

            var weather = await WeatherBusinessLogic.GetWeather(zip);
            GetWeatherButton.Text = weather.Title;

        }
    }
}
