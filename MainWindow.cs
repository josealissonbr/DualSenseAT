using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        JObject repojson = Functions.apiFunctions.getGames();

        public void setgameWindow(int index)
        {
            gameLbl.Text = repojson["games"][index]["name"].ToString();
            WebClient client = new WebClient();
            Stream stream_data = new MemoryStream(client.DownloadData(repojson["games"][index]["picture_url"].ToString()));
            gamePicture.Image = Image.FromStream(stream_data); 
           // Functions.Console.log(repojson["games"][index]["name"].ToString(), this.consoleOutput);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Setup GamesTab

            Functions.Console.log("Setting up games tab...", this.consoleOutput);
            listBox1.Items.Clear();
            foreach (var item in repojson["games"])
            {
                listBox1.Items.Add(item["name"].ToString());
                Functions.Console.log(item["name"].ToString() + " loaded!", this.consoleOutput);
                Functions.Console.log(item["picture_url"].ToString() + " loaded!", this.consoleOutput);

            }
            Functions.Console.log("Program Initialized!", this.consoleOutput);
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Functions.Console.HandleCmd(this.consoleOutput, this.consoleInputBox);
        }

        private void gameTab_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setgameWindow(listBox1.SelectedIndex);
        }
    }
}
