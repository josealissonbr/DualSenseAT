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
    public partial class SetupWindow : KryptonForm
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        FileInfo[] langList = { };

        private void LoadLangsList()
        {
            DirectoryInfo d = new DirectoryInfo(Constants.LANG_PATH);

            langList = d.GetFiles("*.json"); //Getting Json files

            foreach (FileInfo file in langList)
            {
                langCBox.Items.Add(file.Name.Replace(".json", ""));
            }
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            LoadLangsList();
        }

        private void atButton1_Click(object sender, EventArgs e)
        {
            Functions.UIFunctions.setDefaultLang(langCBox.Text);
            if (langCBox.SelectedIndex == -1)
            {
                if (MessageBox.Show(this, "You have not selected any language, if you continue the default language will be set to English (en_US)", Constants.AppName, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    Functions.UIFunctions.setDefaultLang("en_US");
                }
            }

            

            MessageBox.Show("DualSenseAT will restart", "Setup Success!");

            Application.Restart();

        }
    }
}
