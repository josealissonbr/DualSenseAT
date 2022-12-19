using ComponentFactory.Krypton.Toolkit;
using DualSenseAT.V2.components;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualSenseAT.V2.Views
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();


        }

        public static JObject homejson_Object;

        JObject repojson = Functions.apiFunctions.getGames();

        public static ImageList sliderImages;

        static int slider_step = 0;

        static int SELECTED_GAME_ID = 0;

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void test()
        {
            MessageBox.Show("123");
        }

        private void LoadGamesList()
        {
            guna2Panel8.Controls.Clear();
            int i = 0;
            foreach (var item in repojson["games"])
            {

                game_icon_fragment gameIcon = ControlExtensions.Clone<game_icon_fragment>(game_icon_fragment1);
                gameIcon.GAME_ID = int.Parse(item["app_id"].ToString());
                gameIcon.Dock = DockStyle.Left;
                gameIcon.GAME_NAME = item["name"].ToString();
                gameIcon.Name = "icon_"+ int.Parse(item["app_id"].ToString());
                gameIcon.GAME_PIC_URL = item["picture_url"].ToString();
                gameIcon.ParentUC = this;
                /* (s, e) =>
                {
                    //int teste = gameIcon.GAME_ID;
                    //MessageBox.Show(teste.ToString());
                    MessageBox.Show("123");
                };*/

                guna2Panel8.Controls.Add(gameIcon);

                if (i == 4)
                    break;

                i++;

            }
            
            foreach (Control control in guna2Panel8.Controls)
            {
                control.Click += (s, e) =>
                {
                    MessageBox.Show("123");
                };
            }


        }

        public void showGameDetails(int GAME_ID)
        {

            foreach (var item in repojson["games"])
            {
                if (GAME_ID == int.Parse(item["app_id"].ToString())) {

                    materialTabControl1.SelectedTab = GameDetailsTab;
                    label26.Text = item["name"].ToString();
                    SELECTED_GAME_ID = GAME_ID;

                    WebClient wc = new WebClient();

                    using (MemoryStream wc_stream = new MemoryStream(wc.DownloadData(item["picture_url"].ToString())))
                    {
                        guna2ImageButton14.Image = Image.FromStream(wc_stream);
                        guna2ImageButton14.HoverState.Image = Image.FromStream(wc_stream);
                    }
                }
            }

            
        } 

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadGamesList();
        }

        private void game_icon_fragment1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = DashboardTab;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }

}
