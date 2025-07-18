using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFilesAndDB
{
    public static class ConnectionSettingsManager
    {
        public static string GetStringConnect()
        {
            return string.IsNullOrWhiteSpace(Properties.Settings.Default.UserStringConnect)
                ? ConfigurationManager.AppSettings["stringConnect"]
                : Properties.Settings.Default.UserStringConnect;
        }

        public static string GetDefaultConnect()
        {
            return string.IsNullOrWhiteSpace(Properties.Settings.Default.UserDefaultConnect)
                ? ConfigurationManager.AppSettings["defaultStringConnect"]
                : Properties.Settings.Default.UserDefaultConnect;
        }

        public static void SetUserConnections(string main, string def)
        {
            Properties.Settings.Default.UserStringConnect = main;
            Properties.Settings.Default.UserDefaultConnect = def;
            Properties.Settings.Default.Save();
        }
    }
}
