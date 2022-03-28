using MetroFramework.Controls;
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
            if (index == -1)
                return;
            gameLbl.Text = repojson["games"][index]["name"].ToString();
            WebClient client = new WebClient();
            Stream stream_data = new MemoryStream(client.DownloadData(repojson["games"][index]["picture_url"].ToString()));
            gamePicture.Image = Image.FromStream(stream_data); 
        }

        private void LoadGameMod(int index)
        {
            if (index == -1)
                return;

            Functions.Console.log("Loading Game: " + repojson["games"][index]["name"].ToString(), this.consoleOutput);
            Functions.Console.log(repojson["games"][index].ToString(), this.consoleOutput);
            Functions.Console.log("========================================================", this.consoleOutput);
            gameloadDialog gameDialog = new gameloadDialog();
            gameDialog.gameName = repojson["games"][index]["name"].ToString(); 
            gameDialog.picture_url = repojson["games"][index]["picture_url"].ToString(); 
            gameDialog.app_id = int.Parse(repojson["games"][index]["app_id"].ToString());
            gameDialog.isSteamGame = bool.Parse(repojson["games"][index]["isSteamGame"].ToString());
            gameDialog.StartPosition = FormStartPosition.Manual;
            gameDialog.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);

            gameDialog.ShowDialog();
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoadGameMod(listBox1.SelectedIndex);
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (setting_darkModeToggle.Checked)
            {
                //Dark mode exec code 
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }
    }
}
