using System;
using System.IO;

namespace HelperApp.Constants
{
    public static class ApplicationConstants
    {
        public static readonly string SETTINGS_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings");

        public static readonly string WEATHER_API_KEY = "YOUR_API_KEY_HERE"; // FROM: https://openweathermap.org/api
        public static readonly string DEFAULT_COUNTRY = "tr";
        public static readonly string DEFAULT_CITY = "Eskişehir";
    }
}
