using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.DataServices
{
    class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(queryString);

            if (responseMessage == null)
                return null;

            var content = await responseMessage.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject(content);
            return data;
        }
    }
}
