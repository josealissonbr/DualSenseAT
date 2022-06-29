using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{

    static class Program
    {

        public static void RunSetup()
        {
            if (!Directory.Exists(Constants.TEMP_PATH))
                Directory.CreateDirectory(Constants.TEMP_PATH);

            using (WebClient wclient = new WebClient())
            {
                wclient.DownloadFile(Constants.BASE_URL + "\\Localizations.zip", Constants.TEMP_PATH + "\\Localizations.zip");
                try
                {
                    ZipFile.ExtractToDirectory(Constants.TEMP_PATH + "\\Localizations.zip", Constants.LANG_PATH);
                }
                catch
                {

                }
            }

            Application.Run(new SetupWindow());
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //debug purposes
            Session.SteamData.vanityUrl = "SayoriBR";
            Session.SteamData.webApiKey = "1E393413595E51AAC284177A39FEE6E6";

            //Resolve steamID64
            Functions.apiFunctions.loadSteamData();

            //MessageBox.Show(Session.SteamData.UserData.SteamID64);

             //Application.Run(new MainWindowV3());
            //return for tests
           // return;

            var Settings = new IniFile(Constants.TEMP_PATH + "\\DualSenseAT_settings.ini");
            UserPreferences.LANG_CODE = Settings.Read("Lang");
#if (DEBUG)
            //Set Default Lang for Debug
            //UserPreferences.LANG_CODE = "en_US";
#endif

            if (!Directory.Exists(Constants.BASE_TEMP_PATH))
            {
                Directory.CreateDirectory(Constants.BASE_TEMP_PATH);

                RunSetup();
            }
            else
            {

                

                if (Settings.Read("is_installed") == "true")
                {
                    Application.Run(new SplashWindow());
                }
                else
                {
                    RunSetup();
                }
                
            }

            
        }
    }
}
