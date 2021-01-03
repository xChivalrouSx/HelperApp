using System.Windows.Forms;
using WeatherLibrary.DTOs;

namespace WeatherLibrary.Controls
{
    public partial class WeatherControl : UserControl
    {
        public WeatherControl(WeatherResponse weatherResponse)
        {
            InitializeComponent();

            lblWeatherInfo.Text = weatherResponse.weather[0].description.ToUpper();
            lblTemperature.Text = weatherResponse.main.temp.ToString() + "°C";

            string weatherIconName = weatherResponse.weather[0].icon + "@2x.png";
            pBoxWeather.Load("http://openweathermap.org/img/wn/" + weatherIconName);
        }
    }
}
