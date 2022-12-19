using DualSenseAT.V2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT.V2.components
{
    public partial class game_icon_fragment : UserControl
    {
        public dashboard ParentUC{ get; set; }

        public game_icon_fragment()
        {
            InitializeComponent();
        }

        public int GAME_ID = 0;
        public string GAME_NAME = "undefined";
        public string GAME_PIC_URL = "https://static.thenounproject.com/png/194055-200.png";
        public bool isSteamGame = false;

        static byte[] pic_data;


        public int gameID
        {
            get { return GAME_ID; }
        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            ParentUC.showGameDetails(GAME_ID);
        }

        private void game_icon_fragment_Load(object sender, EventArgs e)
        {
            loadContent.RunWorkerAsync();
        }

        private void loadContent_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc = new WebClient();
            pic_data = wc.DownloadData(GAME_PIC_URL);
            
        }

        private void loadContent_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label10.Text = GAME_NAME;

            using (MemoryStream wc_stream = new MemoryStream(pic_data))
            {
                guna2ImageButton8.Image = Image.FromStream(wc_stream);
                guna2ImageButton8.HoverState.Image = Image.FromStream(wc_stream);
            }
            
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
