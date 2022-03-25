using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Functions.Console.log("Program Initialized!", this.consoleOutput);
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Functions.Console.HandleCmd(this.consoleOutput, this.consoleInputBox);
        }
    }
}
