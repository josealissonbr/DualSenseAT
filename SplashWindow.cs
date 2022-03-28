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
    public partial class SplashWindow : MetroFramework.Forms.MetroForm
    {
        public SplashWindow()
        {
            InitializeComponent();
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadLangs()
        {
            if (!Directory.Exists(Constants.LANG_PATH))
            {
                Directory.CreateDirectory(Constants.LANG_PATH);

                //Download langs from repo
            }
            else
            {
                //Get lang list from langs path
                var langs = Directory.GetDirectories(Constants.LANG_PATH);
                foreach (var item in langs)
                {
                    //add langs to comboBox
                    metroComboBox1.Items.Add( new DirectoryInfo(item).Name);
                }
            }
        }

        private void SplashWindow_Load(object sender, EventArgs e)
        {
            LoadLangs();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
