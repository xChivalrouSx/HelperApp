using HelperApp.Constants;
using HelperApp.Data;
using HelperApp.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeatherLibrary;
using WeatherLibrary.Constants;
using WeatherLibrary.Controls;

namespace HelperApp
{
    public partial class WeatherForm : Form
    {
        private Weather weather;

        public WeatherForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            weather = new Weather(
                ApplicationConstants.WEATHER_API_KEY, 
                ApplicationConstants.DEFAULT_COUNTRY, 
                ApplicationConstants.DEFAULT_CITY,
                UnitsType.METRIC);

            WeatherControl weatherControl = weather.GetWeatherControl();
            this.Controls.Add(weatherControl);
            pnlTop.BackColor = weatherControl.BackColor;
            this.Size = new Size(weatherControl.Width, weatherControl.Height);

            Settings settings = SettingsHelper.GetSettings();
            SetLocation(settings.WeatherStartScreen);
            
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = settings.IsWeatherAlwaysTop;
        }

        public void SetLocation(int screenIndex) 
        {
            List<Screen> orderedScreen = Screen.AllScreens.OrderBy(x => x.Bounds.X).ToList();
            if (orderedScreen.Count <= screenIndex)
            {
                screenIndex = 0;
                SettingsHelper.SetSettings("WeatherStartScreen", screenIndex);
            }
            Screen appScreen = orderedScreen[screenIndex];

            int xPosition = appScreen.Bounds.X + appScreen.WorkingArea.Width - this.Width;
            int yPosition = 0;
            this.Location = new Point(xPosition, yPosition);
        }


        #region [ - Form Move Without Border - ]

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void weatherForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion [ - Form Move Without Border - ]

    }
}
