using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if (DEBUG)
            //Set Default Lang for Debug
            UserPreferences.LANG_CODE = "en_US";
#endif


            Application.Run(new SetupWindow());
        }
    }
}
