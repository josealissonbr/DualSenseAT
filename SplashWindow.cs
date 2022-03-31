using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    public partial class SplashWindow : KryptonForm
    {
        public SplashWindow()
        {
            InitializeComponent();
        }

        static int steps = 0;

        public void DownloadHome()
        {
            UpdateLbl.Text = "Fetching Home data...";
            using (WebClient cliente = new WebClient())
            {

                var pathfinal = Constants.BASE_TEMP_PATH + "home.json";
                var uri = new Uri(Constants.BASE_URL + "home/home.json");

                cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                cliente.DownloadFileAsync(uri, pathfinal);
            }

            
        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            UpdateLbl.Text = "Fetching Games...";
            Functions.apiFunctions.getGames();

            steps++;
            if (steps == 1)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                Main2Window mainWindow = new Main2Window();

                mainWindow.Location = this.Location;
                
                mainWindow.Show();
            }
            
        }

        private void EveryTick_Tick(object sender, EventArgs e)
        {

        }

        private void SplashWindow_Load(object sender, EventArgs e)
        {
            UpdateLbl.Text = "Checking Updates...";
            checkUpdates.RunWorkerAsync();

        }

        private void checkUpdates_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            DownloadHome();

            EveryTick.Enabled = true;
        }
    }
}
