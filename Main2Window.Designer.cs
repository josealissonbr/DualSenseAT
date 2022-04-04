namespace DualSenseAT
{
    partial class Main2Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2Window));
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GamesPage = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonListBox1 = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.infoBarPanel = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.everyTicker = new System.Windows.Forms.Timer(this.components);
            this.homeJson = new System.ComponentModel.BackgroundWorker();
            this.sliderTrade = new System.Windows.Forms.Timer(this.components);
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.featuredPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atButton2 = new DualSenseAT.ExtraControls.ATButton();
            this.atButton1 = new DualSenseAT.ExtraControls.ATButton();
            this.atButton3 = new DualSenseAT.ExtraControls.ATButton();
            this.atButton6 = new DualSenseAT.ExtraControls.ATButton();
            this.atButton5 = new DualSenseAT.ExtraControls.ATButton();
            this.atButton4 = new DualSenseAT.ExtraControls.ATButton();
            this.StatusLED = new DualSenseAT.ExtraControls.ATButton();
            this.InfoTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.SettingsTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.GamesTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.HomeTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.langCBox = new MetroFramework.Controls.MetroComboBox();
            this.tabsPanel.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.GamesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.infoBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.materialTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuredPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsPanel
            // 
            this.tabsPanel.Controls.Add(this.InfoTabButton);
            this.tabsPanel.Controls.Add(this.SettingsTabButton);
            this.tabsPanel.Controls.Add(this.GamesTabButton);
            this.tabsPanel.Controls.Add(this.HomeTabButton);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 0);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(984, 36);
            this.tabsPanel.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HomePage);
            this.materialTabControl1.Controls.Add(this.GamesPage);
            this.materialTabControl1.Controls.Add(this.SettingsPage);
            this.materialTabControl1.Controls.Add(this.InfoPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 66);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(984, 495);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.HomePage.Controls.Add(this.pictureBox2);
            this.HomePage.Controls.Add(this.featuredPicBox);
            this.HomePage.Controls.Add(this.pictureBox3);
            this.HomePage.Controls.Add(this.atButton2);
            this.HomePage.Controls.Add(this.label2);
            this.HomePage.Controls.Add(this.atButton1);
            this.HomePage.Controls.Add(this.label1);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(976, 469);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last added Games";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Featured Games";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GamesPage
            // 
            this.GamesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.GamesPage.Controls.Add(this.kryptonPanel1);
            this.GamesPage.Controls.Add(this.kryptonListBox1);
            this.GamesPage.Location = new System.Drawing.Point(4, 22);
            this.GamesPage.Name = "GamesPage";
            this.GamesPage.Padding = new System.Windows.Forms.Padding(3);
            this.GamesPage.Size = new System.Drawing.Size(976, 469);
            this.GamesPage.TabIndex = 1;
            this.GamesPage.Text = "Games";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.atButton3);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(316, 24);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(637, 437);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel1.StateCommon.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.MaximumSize = new System.Drawing.Size(637, 33);
            this.label3.MinimumSize = new System.Drawing.Size(637, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(637, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Featured Games";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 10);
            this.panel1.TabIndex = 5;
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Items.AddRange(new object[] {
            "Teste1",
            "Teste2"});
            this.kryptonListBox1.Location = new System.Drawing.Point(28, 24);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Size = new System.Drawing.Size(272, 437);
            this.kryptonListBox1.StateCheckedNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(115)))));
            this.kryptonListBox1.StateCheckedNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(115)))));
            this.kryptonListBox1.StateCheckedNormal.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateCheckedPressed.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateCheckedTracking.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonListBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonListBox1.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonListBox1.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonListBox1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateDisabled.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StatePressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StatePressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StatePressed.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(132)))));
            this.kryptonListBox1.StateTracking.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonListBox1.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(115)))));
            this.kryptonListBox1.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(115)))));
            this.kryptonListBox1.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonListBox1.TabIndex = 0;
            this.kryptonListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox1_SelectedIndexChanged);
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SettingsPage.Controls.Add(this.materialTabControl2);
            this.SettingsPage.Controls.Add(this.kryptonPanel2);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(976, 469);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.panel2);
            this.kryptonPanel3.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel3.Controls.Add(this.label4);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(580, 394);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "App Settings";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.atButton6);
            this.kryptonPanel2.Controls.Add(this.atButton5);
            this.kryptonPanel2.Controls.Add(this.atButton4);
            this.kryptonPanel2.Location = new System.Drawing.Point(32, 23);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(287, 426);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel2.TabIndex = 0;
            // 
            // InfoPage
            // 
            this.InfoPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.InfoPage.Location = new System.Drawing.Point(4, 22);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(976, 469);
            this.InfoPage.TabIndex = 3;
            this.InfoPage.Text = "Info";
            // 
            // infoBarPanel
            // 
            this.infoBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.infoBarPanel.Controls.Add(this.StatusLED);
            this.infoBarPanel.Controls.Add(this.StatusLbl);
            this.infoBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoBarPanel.Location = new System.Drawing.Point(0, 36);
            this.infoBarPanel.Name = "infoBarPanel";
            this.infoBarPanel.Size = new System.Drawing.Size(984, 30);
            this.infoBarPanel.TabIndex = 2;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Hind", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(32, 6);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(59, 20);
            this.StatusLbl.TabIndex = 0;
            this.StatusLbl.Text = "StatusLbl";
            // 
            // everyTicker
            // 
            this.everyTicker.Tick += new System.EventHandler(this.everyTicker_Tick);
            // 
            // homeJson
            // 
            this.homeJson.DoWork += new System.ComponentModel.DoWorkEventHandler(this.homeJson_DoWork);
            this.homeJson.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.homeJson_RunWorkerCompleted);
            // 
            // sliderTrade
            // 
            this.sliderTrade.Interval = 5000;
            this.sliderTrade.Tick += new System.EventHandler(this.sliderTrade_Tick);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Location = new System.Drawing.Point(18, 40);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(572, 5);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kryptonPanel4.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kryptonPanel4.StateCommon.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPanel4.TabIndex = 1;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage1);
            this.materialTabControl2.Controls.Add(this.tabPage2);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(344, 23);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(594, 426);
            this.materialTabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage1.Controls.Add(this.kryptonPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage2.Controls.Add(this.kryptonPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel5.Controls.Add(this.label5);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(580, 394);
            this.kryptonPanel5.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel5.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanel5.TabIndex = 2;
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Location = new System.Drawing.Point(18, 40);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(572, 5);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kryptonPanel6.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.kryptonPanel6.StateCommon.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPanel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mods Settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DualSenseAT.Properties.Resources.image_not_found;
            this.pictureBox2.Location = new System.Drawing.Point(634, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 416);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // featuredPicBox
            // 
            this.featuredPicBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.featuredPicBox.Image = global::DualSenseAT.Properties.Resources.image_not_found;
            this.featuredPicBox.Location = new System.Drawing.Point(49, 37);
            this.featuredPicBox.Name = "featuredPicBox";
            this.featuredPicBox.Size = new System.Drawing.Size(580, 290);
            this.featuredPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.featuredPicBox.TabIndex = 0;
            this.featuredPicBox.TabStop = false;
            this.featuredPicBox.Click += new System.EventHandler(this.featuredPicBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(49, 333);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(580, 120);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // atButton2
            // 
            this.atButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.atButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.atButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.atButton2.BorderRadius = 10;
            this.atButton2.BorderSize = 0;
            this.atButton2.FlatAppearance.BorderSize = 0;
            this.atButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton2.ForeColor = System.Drawing.Color.Green;
            this.atButton2.Location = new System.Drawing.Point(634, 11);
            this.atButton2.Name = "atButton2";
            this.atButton2.Size = new System.Drawing.Size(18, 18);
            this.atButton2.TabIndex = 4;
            this.atButton2.TextColor = System.Drawing.Color.Green;
            this.atButton2.UseVisualStyleBackColor = false;
            // 
            // atButton1
            // 
            this.atButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.atButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.atButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.atButton1.BorderRadius = 10;
            this.atButton1.BorderSize = 0;
            this.atButton1.FlatAppearance.BorderSize = 0;
            this.atButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton1.ForeColor = System.Drawing.Color.Green;
            this.atButton1.Location = new System.Drawing.Point(49, 13);
            this.atButton1.Name = "atButton1";
            this.atButton1.Size = new System.Drawing.Size(18, 18);
            this.atButton1.TabIndex = 1;
            this.atButton1.TextColor = System.Drawing.Color.Green;
            this.atButton1.UseVisualStyleBackColor = false;
            // 
            // atButton3
            // 
            this.atButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.atButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.atButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.atButton3.BorderRadius = 10;
            this.atButton3.BorderSize = 0;
            this.atButton3.FlatAppearance.BorderSize = 0;
            this.atButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton3.Font = new System.Drawing.Font("Hind", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atButton3.ForeColor = System.Drawing.Color.White;
            this.atButton3.Location = new System.Drawing.Point(243, 361);
            this.atButton3.Name = "atButton3";
            this.atButton3.Size = new System.Drawing.Size(150, 47);
            this.atButton3.TabIndex = 4;
            this.atButton3.Text = "Load Game Mod";
            this.atButton3.TextColor = System.Drawing.Color.White;
            this.atButton3.UseVisualStyleBackColor = false;
            this.atButton3.Click += new System.EventHandler(this.atButton3_Click);
            // 
            // atButton6
            // 
            this.atButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton6.BorderColor = System.Drawing.Color.Transparent;
            this.atButton6.BorderRadius = 6;
            this.atButton6.BorderSize = 0;
            this.atButton6.FlatAppearance.BorderSize = 0;
            this.atButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton6.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atButton6.ForeColor = System.Drawing.Color.White;
            this.atButton6.Image = ((System.Drawing.Image)(resources.GetObject("atButton6.Image")));
            this.atButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atButton6.Location = new System.Drawing.Point(16, 104);
            this.atButton6.Name = "atButton6";
            this.atButton6.Size = new System.Drawing.Size(254, 40);
            this.atButton6.TabIndex = 2;
            this.atButton6.Text = "DualSense X Settings";
            this.atButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atButton6.TextColor = System.Drawing.Color.White;
            this.atButton6.UseVisualStyleBackColor = false;
            // 
            // atButton5
            // 
            this.atButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton5.BorderColor = System.Drawing.Color.Transparent;
            this.atButton5.BorderRadius = 6;
            this.atButton5.BorderSize = 0;
            this.atButton5.FlatAppearance.BorderSize = 0;
            this.atButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton5.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atButton5.ForeColor = System.Drawing.Color.White;
            this.atButton5.Image = ((System.Drawing.Image)(resources.GetObject("atButton5.Image")));
            this.atButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atButton5.Location = new System.Drawing.Point(16, 58);
            this.atButton5.Name = "atButton5";
            this.atButton5.Size = new System.Drawing.Size(254, 40);
            this.atButton5.TabIndex = 1;
            this.atButton5.Text = "Mods Settings";
            this.atButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atButton5.TextColor = System.Drawing.Color.White;
            this.atButton5.UseVisualStyleBackColor = false;
            // 
            // atButton4
            // 
            this.atButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.atButton4.BorderColor = System.Drawing.Color.Transparent;
            this.atButton4.BorderRadius = 6;
            this.atButton4.BorderSize = 0;
            this.atButton4.FlatAppearance.BorderSize = 0;
            this.atButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton4.Font = new System.Drawing.Font("Hind", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atButton4.ForeColor = System.Drawing.Color.White;
            this.atButton4.Image = ((System.Drawing.Image)(resources.GetObject("atButton4.Image")));
            this.atButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atButton4.Location = new System.Drawing.Point(16, 12);
            this.atButton4.Name = "atButton4";
            this.atButton4.Size = new System.Drawing.Size(254, 40);
            this.atButton4.TabIndex = 0;
            this.atButton4.Text = "DSAT App";
            this.atButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atButton4.TextColor = System.Drawing.Color.White;
            this.atButton4.UseVisualStyleBackColor = false;
            // 
            // StatusLED
            // 
            this.StatusLED.BackColor = System.Drawing.Color.Lime;
            this.StatusLED.BackgroundColor = System.Drawing.Color.Lime;
            this.StatusLED.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StatusLED.BorderRadius = 10;
            this.StatusLED.BorderSize = 0;
            this.StatusLED.FlatAppearance.BorderSize = 0;
            this.StatusLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLED.ForeColor = System.Drawing.Color.Green;
            this.StatusLED.Location = new System.Drawing.Point(12, 6);
            this.StatusLED.Name = "StatusLED";
            this.StatusLED.Size = new System.Drawing.Size(18, 18);
            this.StatusLED.TabIndex = 0;
            this.StatusLED.TextColor = System.Drawing.Color.Green;
            this.StatusLED.UseVisualStyleBackColor = false;
            // 
            // InfoTabButton
            // 
            this.InfoTabButton.BackColor = System.Drawing.Color.Transparent;
            this.InfoTabButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.InfoTabButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.InfoTabButton.BorderRadius = 0;
            this.InfoTabButton.BorderSize = 0;
            this.InfoTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoTabButton.FlatAppearance.BorderSize = 0;
            this.InfoTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InfoTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InfoTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoTabButton.ForeColor = System.Drawing.Color.White;
            this.InfoTabButton.Image = global::DualSenseAT.Properties.Resources.info_26px;
            this.InfoTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoTabButton.Location = new System.Drawing.Point(456, 0);
            this.InfoTabButton.Name = "InfoTabButton";
            this.InfoTabButton.Size = new System.Drawing.Size(152, 36);
            this.InfoTabButton.TabIndex = 5;
            this.InfoTabButton.Text = "InfoTabButton";
            this.InfoTabButton.TextColor = System.Drawing.Color.White;
            this.InfoTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InfoTabButton.UseVisualStyleBackColor = false;
            this.InfoTabButton.Click += new System.EventHandler(this.InfoTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SettingsTabButton.BorderRadius = 0;
            this.SettingsTabButton.BorderSize = 0;
            this.SettingsTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsTabButton.FlatAppearance.BorderSize = 0;
            this.SettingsTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SettingsTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.ForeColor = System.Drawing.Color.White;
            this.SettingsTabButton.Image = global::DualSenseAT.Properties.Resources.settings_26px;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(304, 0);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(152, 36);
            this.SettingsTabButton.TabIndex = 4;
            this.SettingsTabButton.Text = "SettingsTabButton";
            this.SettingsTabButton.TextColor = System.Drawing.Color.White;
            this.SettingsTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // GamesTabButton
            // 
            this.GamesTabButton.BackColor = System.Drawing.Color.Transparent;
            this.GamesTabButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.GamesTabButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GamesTabButton.BorderRadius = 0;
            this.GamesTabButton.BorderSize = 0;
            this.GamesTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.GamesTabButton.FlatAppearance.BorderSize = 0;
            this.GamesTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.GamesTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.GamesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesTabButton.ForeColor = System.Drawing.Color.White;
            this.GamesTabButton.Image = global::DualSenseAT.Properties.Resources.playstation_26px;
            this.GamesTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GamesTabButton.Location = new System.Drawing.Point(152, 0);
            this.GamesTabButton.Name = "GamesTabButton";
            this.GamesTabButton.Size = new System.Drawing.Size(152, 36);
            this.GamesTabButton.TabIndex = 3;
            this.GamesTabButton.Text = "GamesTabButton";
            this.GamesTabButton.TextColor = System.Drawing.Color.White;
            this.GamesTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GamesTabButton.UseVisualStyleBackColor = false;
            this.GamesTabButton.Click += new System.EventHandler(this.GamesTabButton_Click);
            // 
            // HomeTabButton
            // 
            this.HomeTabButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeTabButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.HomeTabButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.HomeTabButton.BorderRadius = 0;
            this.HomeTabButton.BorderSize = 0;
            this.HomeTabButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeTabButton.FlatAppearance.BorderSize = 0;
            this.HomeTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HomeTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HomeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTabButton.ForeColor = System.Drawing.Color.White;
            this.HomeTabButton.Image = global::DualSenseAT.Properties.Resources.home_16px;
            this.HomeTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeTabButton.Location = new System.Drawing.Point(0, 0);
            this.HomeTabButton.Name = "HomeTabButton";
            this.HomeTabButton.Size = new System.Drawing.Size(152, 36);
            this.HomeTabButton.TabIndex = 2;
            this.HomeTabButton.Text = "HomeTabButton";
            this.HomeTabButton.TextColor = System.Drawing.Color.White;
            this.HomeTabButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeTabButton.UseVisualStyleBackColor = false;
            this.HomeTabButton.Click += new System.EventHandler(this.HomeTabButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroPanel1);
            this.panel2.Location = new System.Drawing.Point(18, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 340);
            this.panel2.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.langCBox);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 13);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(544, 55);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hind", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Language";
            // 
            // langCBox
            // 
            this.langCBox.FormattingEnabled = true;
            this.langCBox.ItemHeight = 23;
            this.langCBox.Location = new System.Drawing.Point(239, 12);
            this.langCBox.Name = "langCBox";
            this.langCBox.Size = new System.Drawing.Size(291, 29);
            this.langCBox.TabIndex = 4;
            this.langCBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.langCBox.UseSelectable = true;
            // 
            // Main2Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.infoBarPanel);
            this.Controls.Add(this.tabsPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main2Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.Black;
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.Black;
            this.StateActive.Header.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.StateActive.Header.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.StateActive.Header.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.StateInactive.Border.Color1 = System.Drawing.Color.Black;
            this.StateInactive.Border.Color2 = System.Drawing.Color.Black;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Back.Color1 = System.Drawing.Color.Black;
            this.StateInactive.Header.Back.Color2 = System.Drawing.Color.Black;
            this.StateInactive.Header.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.StateInactive.Header.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.StateInactive.Header.Border.Color1 = System.Drawing.Color.Black;
            this.StateInactive.Header.Border.Color2 = System.Drawing.Color.Black;
            this.StateInactive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "DualSense AT v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main2Window_FormClosing);
            this.Load += new System.EventHandler(this.Main2Window_Load);
            this.tabsPanel.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            this.GamesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.infoBarPanel.ResumeLayout(false);
            this.infoBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuredPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabsPanel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage GamesPage;
        private System.Windows.Forms.Panel infoBarPanel;
        private ExtraControls.ATButton HomeTabButton;
        private ExtraControls.ATButton GamesTabButton;
        private ExtraControls.ATButton SettingsTabButton;
        private ExtraControls.ATButton InfoTabButton;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabPage InfoPage;
        private ExtraControls.ATButton StatusLED;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Timer everyTicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox featuredPicBox;
        private ExtraControls.ATButton atButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ExtraControls.ATButton atButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker homeJson;
        private System.Windows.Forms.Timer sliderTrade;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExtraControls.ATButton atButton3;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ExtraControls.ATButton atButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private System.Windows.Forms.Label label5;
        private ExtraControls.ATButton atButton6;
        private ExtraControls.ATButton atButton5;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox langCBox;
    }
}