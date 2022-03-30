using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    public partial class Main2Window : KryptonForm
    {
        public Main2Window()
        {
            InitializeComponent();
        }

        private void LoadLang()
        {
            string lang_file = Constants.LANG_PATH + "\\Localization\\" + UserPreferences.LANG_CODE + ".json";
            if (!File.Exists(lang_file))
            {
                MessageBox.Show("Failed to Load Selected Lang " + UserPreferences.LANG_CODE, Constants.AppName);
                return;
            }

            var Lang = new IniFile(Constants.LANG_PATH + "\\Localization\\" + UserPreferences.LANG_CODE + ".json");

            HomeTabButton.Text = Lang.Read("HomeTabButton");
        }

        private void Main2Window_Load(object sender, EventArgs e)
        {

        }
    }
}
