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
            DirectoryInfo d = new DirectoryInfo(Constants.LANG_PATH); //Assuming Test is your Folder

            langList = d.GetFiles("*.json"); //Getting Text files

            foreach (FileInfo file in langList)
            {
                langCBox.Items.Add(file.Name.Replace(".json", ""));
            }
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
