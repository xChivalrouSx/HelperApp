using System;
using WeatherLibrary.Constants;

namespace WeatherLibrary
{
    public class Weather
    {
        public string ApiKey { get;  set; }
        public string Country { get; set; }
        public string City { get; set; }
        public UnitsType UnitsType { get; set; }

        public Weather(string apiKey, string country, string city, UnitsType unitsType) {
            ApiKey = apiKey;
            Country = country;
            City = city;
            UnitsType = unitsType;
        }

        public Weather(string apiKey, string country, string city) : this(apiKey, country, city, UnitsType.STANDARD) { }

        public Weather(string apiKey, string city) : this(apiKey, string.Empty, city, UnitsType.STANDARD) { }

    }
}
