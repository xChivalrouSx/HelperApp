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
        public WeatherControl WeatherControl { get; set; }

        public WeatherForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Settings settings = SettingsHelper.GetSettings();

            weather = new Weather(
                ApplicationConstants.WEATHER_API_KEY, 
                ApplicationConstants.DEFAULT_COUNTRY, 
                ApplicationConstants.DEFAULT_CITY,
                UnitsType.METRIC);

            WeatherControl = new WeatherControl(weather, settings.WeatherRefreshRate);
            this.Controls.Add(WeatherControl);
            pnlTop.BackColor = WeatherControl.BackColor;
            this.Size = new Size(WeatherControl.Width, WeatherControl.Height);

            SetLocation(settings.WeatherStartScreen, settings.WeatherLocation);
            
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = settings.IsWeatherAlwaysTop;
        }

        public void SetLocation(int screenIndex, int locationIndex) 
        {
            List<Screen> orderedScreen = Screen.AllScreens.OrderBy(x => x.Bounds.X).ToList();
            if (orderedScreen.Count <= screenIndex)
            {
                screenIndex = 0;
                SettingsHelper.SetSettings("WeatherStartScreen", screenIndex);
            }
            Screen appScreen = orderedScreen[screenIndex];

            int xPosition = 0;
            int yPosition = 0;
            switch (locationIndex)
            {
                case 0:
                    xPosition = appScreen.Bounds.X;
                    yPosition = 0;
                    break;
                case 1:
                    xPosition = appScreen.Bounds.X + appScreen.WorkingArea.Width - this.Width;
                    yPosition = 0;
                    break;
                case 2:
                    xPosition = appScreen.Bounds.X + appScreen.WorkingArea.Width - this.Width;
                    yPosition = appScreen.Bounds.Y + appScreen.WorkingArea.Height - this.Height;
                    break;
                case 3:
                    xPosition = appScreen.Bounds.X;
                    yPosition = appScreen.Bounds.Y + appScreen.WorkingArea.Height - this.Height;
                    break;
            }
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
