using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    public partial class gameloadDialog : Form
    {
        public gameloadDialog()
        {
            InitializeComponent();
        }

        public string gameName;
        public string picture_url;
        public int app_id;
        public bool isSteamGame;

        private void gameloadDialog_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream image_data = new MemoryStream(client.DownloadData(picture_url));
            pictureBox1.Image = Image.FromStream(image_data);

            label1.Text = gameName;

            getGameFiles();
        }

        public void getGameFiles()
        {
            metroProgressBar1.ProgressBarStyle = ProgressBarStyle.Continuous;
            metroProgressBar1.Value = 0;
            if (!Directory.Exists(Constants.TEMP_PATH + "\\" + app_id + "\\download\\"))
                Directory.CreateDirectory(Constants.TEMP_PATH + "\\" + app_id + "\\download\\");


            WebClient client = new WebClient();
            client.DownloadProgressChanged += ProgressChanged;
            client.DownloadFileCompleted += Completed;
            client.DownloadFileAsync(new Uri(Constants.BASE_URL + "games/"+app_id+"/pack_data.zip"), Constants.TEMP_PATH + "\\"+app_id+"\\download\\pack_data.zip");
        }

        public void startMod()
        {
            //Read game Manifests
            var json = File.ReadAllText(Constants.TEMP_PATH + "\\" + app_id + "\\download\\gameManifest.json");
            JObject manifest = JObject.Parse(json);

            Console.WriteLine(manifest.ToString(Newtonsoft.Json.Formatting.Indented));

            //Prepare .EXE Loading...


        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            metroProgressBar1.ProgressBarStyle = ProgressBarStyle.Marquee;
            metroProgressBar1.Value = 40;
            try
            {
                ZipFile.ExtractToDirectory(Constants.TEMP_PATH + "\\" + app_id + "\\download\\pack_data.zip", Constants.TEMP_PATH + "\\" + app_id + "\\download");
                metroProgressBar1.ProgressBarStyle = ProgressBarStyle.Continuous;
                metroProgressBar1.Value = 100;
            }
            catch (Exception ex)
            {

            }
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
