using Newtonsoft.Json;
using System.Net.Http;
using WeatherLibrary.DTOs;

namespace WeatherLibrary
{
    public static class WeatherHelper
    {
        public static WeatherResponse GetCurrentWeatherAsync(Weather weather)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q={0},{1}&appid={2}&units={3}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(string.Format(url, weather.City, weather.Country, weather.ApiKey, weather.UnitsType.ToString().ToLower())).Result;
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<WeatherResponse>(responseAsString);
        }
    }
}
