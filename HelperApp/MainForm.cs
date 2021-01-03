using HelperApp.Constants;
using HelperApp.Data;
using HelperApp.Helper;
using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace HelperApp
{
    public partial class MainForm : Form
    {
        public static Form GetForm<Form>() 
        {
            return Application.OpenForms.OfType<Form>().FirstOrDefault();
        }

        public MainForm()
        {
            InitializeComponent();
            Init();
            StartScreens();
        }

        private void Init()
        {
            if (!File.Exists(ApplicationConstants.SETTINGS_FILE)) 
            {
                Settings settings = new Settings()
                {
                    WeatherStartScreen = 0,
                    IsWeatherAlwaysTop = true,
                    ShowWeather = true
                };

                File.Create(ApplicationConstants.SETTINGS_FILE).Close();
                SettingsHelper.SetSettings(settings);
            }
        }

        private void StartScreens()
        {
            Settings settings = SettingsHelper.GetSettings();

            if (settings.ShowWeather) 
            {
                new WeatherForm().Show();
            }
        }

        private void itemClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void itemSettings_Click(object sender, EventArgs e)
        {
            CheckAndOpenForm<SettingsForm>(new SettingsForm());
        }

        private void CheckAndOpenForm<Form>(System.Windows.Forms.Form formObject) 
        {
            if (!Application.OpenForms.OfType<Form>().Any())
            {
                formObject.Show();
            }
        }
    }
}
