using Memory;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private Mem memLib = new Mem();

        private int processID;
        private bool processOpen = false;

        private bool validNumber = false;
        private int temporaryNumb = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnTime_Tick(object sender, EventArgs e)
        {

        }
    }
}
