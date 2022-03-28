namespace DualSenseAT
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.gamesTab = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.gameLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.versionLbl = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.setting_darkModeToggle = new MetroFramework.Controls.MetroToggle();
            this.debugTab = new MetroFramework.Controls.MetroTabPage();
            this.consoleInputBox = new MetroFramework.Controls.MetroTextBox();
            this.consoleOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.gamesTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.debugTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.gamesTab);
            this.metroTabControl1.Controls.Add(this.settingsTab);
            this.metroTabControl1.Controls.Add(this.debugTab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(784, 561);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.panel1);
            this.gamesTab.Controls.Add(this.listBox1);
            this.gamesTab.HorizontalScrollbarBarColor = true;
            this.gamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.gamesTab.HorizontalScrollbarSize = 10;
            this.gamesTab.Location = new System.Drawing.Point(4, 35);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Size = new System.Drawing.Size(776, 522);
            this.gamesTab.TabIndex = 0;
            this.gamesTab.Text = "Games";
            this.gamesTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gamesTab.VerticalScrollbarBarColor = true;
            this.gamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.gamesTab.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.gamePicture);
            this.panel1.Controls.Add(this.gameLbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(228, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 507);
            this.panel1.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(223, 434);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 48);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Load Mod";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gamePicture
            // 
            this.gamePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gamePicture.Location = new System.Drawing.Point(3, 80);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(533, 325);
            this.gamePicture.TabIndex = 1;
            this.gamePicture.TabStop = false;
            // 
            // gameLbl
            // 
            this.gameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameLbl.AutoSize = true;
            this.gameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gameLbl.ForeColor = System.Drawing.Color.White;
            this.gameLbl.Location = new System.Drawing.Point(219, 28);
            this.gameLbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(100, 24);
            this.gameLbl.TabIndex = 0;
            this.gameLbl.Text = "label1";
            this.gameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "item1",
            "item2"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.MinimumSize = new System.Drawing.Size(186, 434);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 516);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox2);
            this.settingsTab.Controls.Add(this.groupBox1);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 38);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(776, 519);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.versionLbl);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Updates";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(7, 54);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(247, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Check Updates";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(7, 32);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(126, 19);
            this.versionLbl.TabIndex = 0;
            this.versionLbl.Text = "Current version: v0.1";
            this.versionLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.setting_darkModeToggle);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual settings";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Dark mode";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // setting_darkModeToggle
            // 
            this.setting_darkModeToggle.AutoSize = true;
            this.setting_darkModeToggle.Location = new System.Drawing.Point(90, 32);
            this.setting_darkModeToggle.Name = "setting_darkModeToggle";
            this.setting_darkModeToggle.Size = new System.Drawing.Size(80, 17);
            this.setting_darkModeToggle.TabIndex = 1;
            this.setting_darkModeToggle.Text = "Off";
            this.setting_darkModeToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setting_darkModeToggle.UseSelectable = true;
            this.setting_darkModeToggle.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.consoleInputBox);
            this.debugTab.Controls.Add(this.consoleOutput);
            this.debugTab.HorizontalScrollbarBarColor = true;
            this.debugTab.HorizontalScrollbarHighlightOnWheel = false;
            this.debugTab.HorizontalScrollbarSize = 10;
            this.debugTab.Location = new System.Drawing.Point(4, 35);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(776, 522);
            this.debugTab.TabIndex = 2;
            this.debugTab.Text = "Debug";
            this.debugTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.debugTab.VerticalScrollbarBarColor = true;
            this.debugTab.VerticalScrollbarHighlightOnWheel = false;
            this.debugTab.VerticalScrollbarSize = 10;
            // 
            // consoleInputBox
            // 
            this.consoleInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.consoleInputBox.CustomButton.Image = null;
            this.consoleInputBox.CustomButton.Location = new System.Drawing.Point(738, 1);
            this.consoleInputBox.CustomButton.Name = "";
            this.consoleInputBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.consoleInputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleInputBox.CustomButton.TabIndex = 1;
            this.consoleInputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleInputBox.CustomButton.UseSelectable = true;
            this.consoleInputBox.CustomButton.Visible = false;
            this.consoleInputBox.Lines = new string[0];
            this.consoleInputBox.Location = new System.Drawing.Point(8, 488);
            this.consoleInputBox.MaxLength = 32767;
            this.consoleInputBox.Name = "consoleInputBox";
            this.consoleInputBox.PasswordChar = '\0';
            this.consoleInputBox.PromptText = "Enter command";
            this.consoleInputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleInputBox.SelectedText = "";
            this.consoleInputBox.SelectionLength = 0;
            this.consoleInputBox.SelectionStart = 0;
            this.consoleInputBox.ShortcutsEnabled = true;
            this.consoleInputBox.Size = new System.Drawing.Size(760, 23);
            this.consoleInputBox.TabIndex = 2;
            this.consoleInputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.consoleInputBox.UseSelectable = true;
            this.consoleInputBox.WaterMark = "Enter command";
            this.consoleInputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleInputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.consoleInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.consoleOutput.CustomButton.Image = null;
            this.consoleOutput.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.consoleOutput.CustomButton.Name = "";
            this.consoleOutput.CustomButton.Size = new System.Drawing.Size(467, 467);
            this.consoleOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleOutput.CustomButton.TabIndex = 1;
            this.consoleOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleOutput.CustomButton.UseSelectable = true;
            this.consoleOutput.CustomButton.Visible = false;
            this.consoleOutput.Lines = new string[] {
        "DualSense AT - 2022 by JoseAlissonBR"};
            this.consoleOutput.Location = new System.Drawing.Point(8, 3);
            this.consoleOutput.MaxLength = 32767;
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.PasswordChar = '\0';
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleOutput.SelectedText = "";
            this.consoleOutput.SelectionLength = 0;
            this.consoleOutput.SelectionStart = 0;
            this.consoleOutput.ShortcutsEnabled = false;
            this.consoleOutput.Size = new System.Drawing.Size(760, 469);
            this.consoleOutput.TabIndex = 3;
            this.consoleOutput.Text = "DualSense AT - 2022 by JoseAlissonBR";
            this.consoleOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.consoleOutput.UseSelectable = true;
            this.consoleOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DualSense AT v0.1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.gamesTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.debugTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage gamesTab;
        private MetroFramework.Controls.MetroTabPage settingsTab;
        private MetroFramework.Controls.MetroTabPage debugTab;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox consoleOutput;
        private MetroFramework.Controls.MetroTextBox consoleInputBox;
        private System.Windows.Forms.Label gameLbl;
        private System.Windows.Forms.PictureBox gamePicture;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle setting_darkModeToggle;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel versionLbl;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
    }
}