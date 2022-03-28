using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class UpdateWindow : Form
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        public JObject updateJson;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateWindow_Load(object sender, EventArgs e)
        {
            label2.Text = "update "+ 
                updateJson["update"][0]["name"].ToString() 
                + " is available, do you want to update now?";
        }


        private void downloadFile()
        {
            button1.Enabled = false;
            button2.Text = "Cancel";
            string downloadPath = Constants.TEMP_PATH + "\\updates\\"+updateJson["update"][0]["code"].ToString();
            
            if (!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }
            else
            {
                Directory.Delete(downloadPath, true);
                Directory.CreateDirectory(downloadPath);

            }
            // This will download a large image from the web, you can change the value
            // i.e a textbox : textBox1.Text
            string url = updateJson["update"][0]["download_link"].ToString();
            

            using (WebClient wc = new WebClient())
            {
                progressBar1.Visible = true;
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(url), downloadPath + "/" + updateJson["update"][0]["code"] + ".zip");
            }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // In case you don't have a progressBar Log the value instead 
            // Console.WriteLine(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;

            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("An error ocurred while trying to download update");

                return;
            }

            progressBar1.Style = ProgressBarStyle.Marquee;

            try
            {
                string downloadPath = Constants.TEMP_PATH + "\\updates\\" + updateJson["update"][0]["code"].ToString();

                ZipFile.ExtractToDirectory(downloadPath + "/" + updateJson["update"][0]["code"] + ".zip", downloadPath);
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 100;

                File.Delete(downloadPath + "/" + updateJson["update"][0]["code"] + ".zip");

                string[] batch = {
                    "ECHO \"Starting move update files\"",
                    "timeout 5",
                    "move *.* ..\\..\\..\\ 2>NUL",
                    "open ..\\..\\..\\DualSenseAT.exe",
                    "Msg * \"Update Success, open DualSenseAT Again!\" "
                };
                File.WriteAllLines(downloadPath + "/" + "updatescript.bat", batch);

                //Process.Start("start", "start \"" + downloadPath + "/" + "updatescript.bat\"");
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = downloadPath + "/" + "updatescript.bat",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        WorkingDirectory = downloadPath + "/"
                    }
                };

                proc.Start();

                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Update succesfully downloaded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            downloadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
