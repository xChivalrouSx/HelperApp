using HelperApp.Constants;
using HelperApp.Data;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace HelperApp.Helper
{
    public static class SettingsHelper
    {
        public static Settings GetSettings() 
        {
            string settingsJson = File.ReadAllText(ApplicationConstants.SETTINGS_FILE);
            return JsonConvert.DeserializeObject<Settings>(settingsJson);
        }

        public static void SetSettings(Settings settings) 
        {
            File.WriteAllText(ApplicationConstants.SETTINGS_FILE, JsonConvert.SerializeObject(settings));
        }

        public static void SetSettings(string fieldName, object value)
        {
            Settings settings = GetSettings();
            foreach (PropertyInfo pInfo in settings.GetType().GetProperties()) 
            {
                if (pInfo.Name.Equals(fieldName)) 
                {
                    pInfo.SetValue(settings, value);
                }
            }
            SetSettings(settings);
        }
    }
}
