using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT.Functions
{
    internal class Console
    {
        public static void log(string message, MetroFramework.Controls.MetroTextBox console)
        {
            console.Text += Environment.NewLine + "["+ DateTime.Now.ToString("h:mm:ss tt")+"] >> " + message; 
        }

        public static void HandleCmd(MetroFramework.Controls.MetroTextBox console, MetroFramework.Controls.MetroTextBox consoleInputBox)
        {
            var fullcmd = consoleInputBox.Text;

            var action = Regex.Replace(fullcmd.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
            var arg1 = String.Empty;

            if (Regex.Replace(fullcmd.Split()[1], @"[^0-9a-zA-Z\ ]+", "") != null)
            {
                arg1 = Regex.Replace(fullcmd.Split()[1], @"[^0-9a-zA-Z\ ]+", "");
            }

        }
    }
}
