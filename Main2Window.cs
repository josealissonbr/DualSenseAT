using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT
{
    public partial class Main2Window : KryptonForm
    {
        public Main2Window()
        {
            InitializeComponent();
        }

        public static JObject homejson_Object;

        JObject repojson = Functions.apiFunctions.getGames();

        public static ImageList sliderImages;

        static int slider_step = 0;

        private Point CenterOfMenuPanel<T>(T control, int height = 0) where T : Control
        {
            Point center = new Point(
                kryptonPanel1.Size.Width / 2 - kryptonPanel1.Width * 2,
                height);

            return center;
        }

        private void LoadLang()
        {
           
            //Load Tab Buttons
            HomeTabButton.Text = Functions.UIFunctions.getLangString("HomeTabButton");
            GamesTabButton.Text = Functions.UIFunctions.getLangString("GamesTabButton");
            SettingsTabButton.Text = Functions.UIFunctions.getLangString("SettingsTabButton");
            InfoTabButton.Text = Functions.UIFunctions.getLangString("InfoTabButton");


            //Apply LangList to ComboBox

            foreach (FileInfo file in Session.langList)
            {
                langCBox.Items.Add(file.Name.Replace(".json", ""));
            }

            langCBox.SelectedItem = UserPreferences.LANG_CODE;

        }

        private void LoadGamesList()
        {
            kryptonListBox1.Items.Clear();
            foreach (var item in repojson["games"])
            {
                kryptonListBox1.Items.Add(item["name"].ToString());
            }
        }
        
        private void setTab(TabPage selectedTab)
        {
            materialTabControl1.SelectedTab = selectedTab;

            //Update Tab Btn backcolor
            if (materialTabControl1.SelectedTab == HomePage)
                HomeTabButton.BackColor = Color.FromArgb(25, 25, 25);
            else
                HomeTabButton.BackColor = Color.Transparent;

            if (materialTabControl1.SelectedTab == GamesPage)
                GamesTabButton.BackColor = Color.FromArgb(25, 25, 25);
            else
                GamesTabButton.BackColor = Color.Transparent;

            if (materialTabControl1.SelectedTab == SettingsPage)
                SettingsTabButton.BackColor = Color.FromArgb(25, 25, 25);
            else
                SettingsTabButton.BackColor = Color.Transparent;

            if (materialTabControl1.SelectedTab == InfoPage)
                InfoTabButton.BackColor = Color.FromArgb(25, 25, 25);
            else
                InfoTabButton.BackColor = Color.Transparent;

        }

        private void ShowGameDetails(int app_id)
        {

        }

        private void LoadGameMod(int index)
        {
            if (index == -1)
                return;

            //Functions.Console.log("Loading Game: " + repojson["games"][index]["name"].ToString(), this.consoleOutput);
            // Functions.Console.log(repojson["games"][index].ToString(), this.consoleOutput);
            // Functions.Console.log("========================================================", this.consoleOutput);
            gameloadDialog gameDialog = new gameloadDialog();
            gameDialog.gameName = repojson["games"][index]["name"].ToString();
            gameDialog.picture_url = repojson["games"][index]["picture_url"].ToString();
            gameDialog.app_id = int.Parse(repojson["games"][index]["app_id"].ToString());
            gameDialog.isSteamGame = bool.Parse(repojson["games"][index]["isSteamGame"].ToString());
            gameDialog.StartPosition = FormStartPosition.Manual;
            gameDialog.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);

            gameDialog.ShowDialog();
        }

        public void setgameWindow(int index)
        {
            if (index == -1)
                return;

            label3.Text = repojson["games"][index]["name"].ToString();
            WebClient client = new WebClient();
            Stream stream_data = new MemoryStream(client.DownloadData(repojson["games"][index]["picture_url"].ToString()));
            pictureBox1.Image = Image.FromStream(stream_data);

            //label3.Location = CenterOfMenuPanel(label3, 10);

            kryptonPanel1.Visible = true;
        }

        private void Main2Window_Load(object sender, EventArgs e)
        {
            LoadLang();

            //Set window title
            this.Text = "DualSense AT v" + Application.ProductVersion;


            materialTabControl1.Update();

            //Set Start Tab
            setTab(HomePage);

            //Load Home Json
            homeJson.RunWorkerAsync();

            //Load Game List
            LoadGamesList();

            //Init Timers
            everyTicker.Enabled = true;
        }



        private void StatusLedController()
        {
            if (!Functions.UIFunctions.isDSXRunning())
            {
                StatusLED.BackColor = Color.Red;
                StatusLbl.Text = "DualSenseX is closed!";
                return;
            }

            

            if (!Functions.NetworkServices.CheckAvailableServerPort(6969))
            {
                StatusLED.BackColor = Color.Red;
                StatusLbl.Text = "UDP Server is not open!";
                return;
            }

            StatusLED.BackColor = Color.Lime;
            StatusLbl.Text = "Ready!";
        }

        private void everyTicker_Tick(object sender, EventArgs e)
        {
            StatusLedController();
        }

        private void HomeTabButton_Click(object sender, EventArgs e)
        {
            setTab(HomePage);
        }

        private void GamesTabButton_Click(object sender, EventArgs e)
        {
            setTab(GamesPage);
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            setTab(SettingsPage);
        }

        private void InfoTabButton_Click(object sender, EventArgs e)
        {
            setTab(InfoPage);
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void homeJson_DoWork(object sender, DoWorkEventArgs e)
        {
            homejson_Object = JObject.Parse(File.ReadAllText(Constants.BASE_TEMP_PATH + "home.json"));

            if (!Directory.Exists(Constants.BASE_TEMP_PATH + "sliders"))
            {
                Directory.CreateDirectory(Constants.BASE_TEMP_PATH + "sliders");
            }

            foreach (var featured in homejson_Object["featured"])
            {
                using (WebClient client = new WebClient()) {
                    client.DownloadFile(featured["picture_url"].ToString(), Constants.BASE_TEMP_PATH + "sliders/"+featured["app_id"] + ".jpg");
                    Console.Write(featured["picture_url"].ToString());
                    

                    
                }
            }
            e.Result = homejson_Object;
        }

        

        private void homeJson_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sliderTrade.Interval = Constants.HomeFeaturedSlider_Intervalms;
            sliderTrade.Enabled = true;

            featuredPicBox.Image = Image.FromFile(Constants.BASE_TEMP_PATH + "sliders/" + homejson_Object["featured"][slider_step]["app_id"].ToString() + ".jpg");

        }
        
        private void sliderTrade_Tick(object sender, EventArgs e)
        {
            featuredPicBox.Image = Image.FromFile(Constants.BASE_TEMP_PATH + "sliders/" + homejson_Object["featured"][slider_step]["app_id"].ToString() + ".jpg");

            if (slider_step == (homejson_Object["featured"].Count() -1))
            {
                slider_step = 0;
                return;
            }
            else
            {
                slider_step++;
            }

        }

        private void featuredPicBox_Click(object sender, EventArgs e)
        {
            //setgameWindow(kryptonListBox1);
        }

        private void Main2Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setgameWindow(kryptonListBox1.SelectedIndex);
        }

        private void atButton3_Click(object sender, EventArgs e)
        {
            LoadGameMod(kryptonListBox1.SelectedIndex);
        }
    }
}
