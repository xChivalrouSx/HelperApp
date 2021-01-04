using HelperApp.Data;
using HelperApp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static HelperApp.Helper.SettingsHelper;

namespace HelperApp
{
    public partial class SettingsForm : Form
    {
        private Settings settings;

        public SettingsForm()
        {
            InitializeComponent();

            settings = SettingsHelper.GetSettings();
            listBoxMain.SelectedIndex = 0;
        }

        private void listBoxMain_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedSetting = listBoxMain.SelectedItem.ToString();
            if (selectedSetting.Equals("Weather"))
            {
                CreateWeatherStartWindowSettings();
                CreateWeatherLocationSettings();
                CreateWeatherRefreshSettings();
                CreateWeatherAlwaysTopSettings();
                CreateWeatherShowSettings();
            }
        }

        #region [ - Weather Settings - ]

        private void CreateWeatherStartWindowSettings()
        {
            cBoxWeatherScreen.SelectedValueChanged -= cBoxWeatherScreen_SelectedValueChanged;

            List<string> screenNameList = new List<string>();
            List<Screen> orderedScreen = Screen.AllScreens.OrderBy(x => x.Bounds.X).ToList();
            for (int i = 0; i < orderedScreen.Count; i++) 
            {
                screenNameList.Add("Screen " + i);
            }

            cBoxWeatherScreen.DataSource = screenNameList;
            cBoxWeatherScreen.SelectedIndex = settings.WeatherStartScreen;
            cBoxWeatherScreen.SelectedValueChanged += cBoxWeatherScreen_SelectedValueChanged;
        }

        private void CreateWeatherLocationSettings()
        {
            cBoxWeatherLocation.SelectedValueChanged -= cBoxWeatherLocation_SelectedValueChanged;

            cBoxWeatherLocation.SelectedIndex = settings.WeatherLocation;
            
            cBoxWeatherLocation.SelectedValueChanged += cBoxWeatherLocation_SelectedValueChanged;
        }

        private void CreateWeatherRefreshSettings()
        {
            cBoxWeatherRefresh.SelectedValueChanged -= cBoxWeatherRefresh_SelectedValueChanged;

            cBoxWeatherRefresh.SelectedIndex = cBoxWeatherRefresh.FindStringExact(settings.WeatherRefreshRate.ToString());

            cBoxWeatherRefresh.SelectedValueChanged += cBoxWeatherRefresh_SelectedValueChanged;
        }

        private void CreateWeatherAlwaysTopSettings()
        {
            checkBoxWeatherAlwaysTop.CheckedChanged -= checkWeatherAlwaysTop_CheckedChanged;

            checkBoxWeatherAlwaysTop.Checked = settings.IsWeatherAlwaysTop;

            checkBoxWeatherAlwaysTop.CheckedChanged += checkWeatherAlwaysTop_CheckedChanged;
        }

        private void CreateWeatherShowSettings()
        {
            checkBoxWeatherShow.CheckedChanged -= checkBoxWeatherShow_CheckedChanged;

            checkBoxWeatherShow.Checked = settings.ShowWeather;

            checkBoxWeatherShow.CheckedChanged += checkBoxWeatherShow_CheckedChanged;
        }

        private void cBoxWeatherScreen_SelectedValueChanged(object sender, EventArgs e)
        {
            SettingsHelper.SetSettings("WeatherStartScreen", cBoxWeatherScreen.SelectedIndex);
            SetFormLocation();
        }

        private void cBoxWeatherLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            SettingsHelper.SetSettings("WeatherLocation", cBoxWeatherLocation.SelectedIndex);
            SetFormLocation();
        }

        private void cBoxWeatherRefresh_SelectedValueChanged(object sender, EventArgs e)
        {
            int refreshRate = Int32.Parse(cBoxWeatherRefresh.SelectedText);

            SettingsHelper.SetSettings("WeatherRefreshRate", refreshRate);
            WeatherForm weatherForm = MainForm.GetForm<WeatherForm>();
            if (weatherForm != null)
            {
                weatherForm.WeatherControl.SetRefreshRate(refreshRate);
            }
        }

        private void checkWeatherAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            SettingsHelper.SetSettings("IsWeatherAlwaysTop", checkBoxWeatherAlwaysTop.Checked);
            WeatherForm weatherForm = MainForm.GetForm<WeatherForm>();
            if (weatherForm != null) 
            {
                weatherForm.TopMost = checkBoxWeatherAlwaysTop.Checked;
            }
        }

        private void checkBoxWeatherShow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsHelper.SetSettings("IsWeatherShow", checkBoxWeatherShow.Checked);
            WeatherForm weatherForm = MainForm.GetForm<WeatherForm>();
            if (weatherForm != null) 
            {
                if (checkBoxWeatherShow.Checked)
                {
                    weatherForm.Show();
                }
                else
                {
                    weatherForm.Hide();
                }
            }
        }

        private void SetFormLocation() 
        {
            WeatherForm weatherForm = MainForm.GetForm<WeatherForm>();
            if (weatherForm != null)
            {
                weatherForm.SetLocation(cBoxWeatherScreen.SelectedIndex, cBoxWeatherLocation.SelectedIndex);
            }
        }

        #endregion [ - Weather Settings - ]

    }

}
