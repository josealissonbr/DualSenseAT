using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualSenseAT.Functions
{
    internal class UIFunctions
    {

        public static string getLangString(string key)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(Constants.LANG_PATH + UserPreferences.LANG_CODE + ".json"));

            if (o1.ContainsKey(key))
            {
                return o1[key]["text"].ToString();
            }
            else
            {
                return key;
            }

            
        }

        public static bool isDSXRunning()
        {
            Process[] pname = Process.GetProcessesByName("DualSenseX");
            if (pname.Length == 0)
                return false;
            else
                return true;
        }

        public static void setDefaultLang(string LANG_CODE)
        {
            UserPreferences.LANG_CODE = LANG_CODE;

            var Settings = new IniFile(Constants.TEMP_PATH + "\\DualSenseAT_settings.ini");
            //Settings.Read("is_installed")
            Settings.Write("Lang", LANG_CODE);
            Settings.Write("is_installed", "true");

        }


    }
}
