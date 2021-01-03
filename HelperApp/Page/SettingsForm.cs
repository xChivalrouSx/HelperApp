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
                CreateWeatherAlwaysTopSettings();
                CreateWeatherShowSettings();
            }
        }

        #region [ - Weather Settings - ]

        private void CreateWeatherStartWindowSettings()
        {
            cBoxWeatherScreen.SelectedValueChanged -= cBoxScreen_SelectedValueChanged;

            List<string> screenNameList = new List<string>();
            List<Screen> orderedScreen = Screen.AllScreens.OrderBy(x => x.Bounds.X).ToList();
            for (int i = 0; i < orderedScreen.Count; i++) 
            {
                screenNameList.Add("Screen " + i);
            }

            cBoxWeatherScreen.DataSource = screenNameList;
            cBoxWeatherScreen.SelectedIndex = settings.WeatherStartScreen;
            cBoxWeatherScreen.SelectedValueChanged += cBoxScreen_SelectedValueChanged;
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

        private void cBoxScreen_SelectedValueChanged(object sender, EventArgs e)
        {
            SettingsHelper.SetSettings("WeatherStartScreen", cBoxWeatherScreen.SelectedIndex);
            WeatherForm weatherForm = MainForm.GetForm<WeatherForm>();
            if (weatherForm != null)
            {
                weatherForm.SetLocation(cBoxWeatherScreen.SelectedIndex);
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

        #endregion [ - Weather Settings - ]

    }
}
