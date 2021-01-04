using System;
using System.Windows.Forms;
using WeatherLibrary.DTOs;

namespace WeatherLibrary.Controls
{
    public partial class WeatherControl : UserControl
    {
        public Weather Weather { get; set; }
        
        private System.Threading.Timer TimerRefresh;

        public WeatherControl(Weather weather, Int32 refreshRate)
        {
            InitializeComponent();
            Weather = weather;
            SetRefreshRate(refreshRate);
        }

        public void SetRefreshRate(int refreshRate)
        {
            if (TimerRefresh != null)
            {
                TimerRefresh.Dispose();
            }

            TimeSpan startTimeSpan = TimeSpan.FromSeconds(5);
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(refreshRate);

            TimerRefresh = new System.Threading.Timer((e) =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => 
                        RefreshWeather()
                    ));
                }
                else 
                {
                    RefreshWeather();
                }
            }, null, startTimeSpan, periodTimeSpan);
        }

        private void RefreshWeather()
        {
            WeatherResponse weatherResponse = WeatherHelper.GetCurrentWeatherAsync(Weather);

            lblWeatherInfo.Text = weatherResponse.weather[0].description.ToUpper();
            lblTemperature.Text = weatherResponse.main.temp.ToString() + "°C";

            string weatherIconName = weatherResponse.weather[0].icon + "@2x.png";
            pBoxWeather.Load("http://openweathermap.org/img/wn/" + weatherIconName);
        }
    }
}
