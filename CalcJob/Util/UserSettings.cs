using CalcJob.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJob.Util
{

    public static class UserSettings
    {
        static bool alwaysOnTop;

        public static bool AlwaysOnTop
        {
            get => GetAlwaysOnTop();
            set => SaveAlwaysOnTop(value);
        }

        private static bool GetAlwaysOnTop()
        {
            return Settings.Default.alwaysOnTop;
        }

        private static void SaveAlwaysOnTop(bool setting)
        {
            alwaysOnTop = setting;
            SaveToSettings(setting);
        }

        private static void SaveToSettings(bool setting)
        {
            Settings.Default.alwaysOnTop = setting;
            Settings.Default.Save();
        }
    }
}
