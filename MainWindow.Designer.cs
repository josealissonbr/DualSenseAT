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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.gamesTab = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.gameLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.debugTab = new MetroFramework.Controls.MetroTabPage();
            this.consoleInputBox = new MetroFramework.Controls.MetroTextBox();
            this.consoleOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.gamesTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.debugTab.SuspendLayout();
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
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(784, 561);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.panel1);
            this.gamesTab.Controls.Add(this.listBox1);
            this.gamesTab.HorizontalScrollbarBarColor = true;
            this.gamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.gamesTab.HorizontalScrollbarSize = 10;
            this.gamesTab.Location = new System.Drawing.Point(4, 38);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Size = new System.Drawing.Size(776, 519);
            this.gamesTab.TabIndex = 0;
            this.gamesTab.Text = "Games";
            this.gamesTab.VerticalScrollbarBarColor = true;
            this.gamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.gamesTab.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gamePicture);
            this.panel1.Controls.Add(this.gameLbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(228, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 516);
            this.panel1.TabIndex = 3;
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
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 35);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(776, 522);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
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
            this.consoleInputBox.CustomButton.Location = new System.Drawing.Point(631, 1);
            this.consoleInputBox.CustomButton.Name = "";
            this.consoleInputBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.consoleInputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleInputBox.CustomButton.TabIndex = 1;
            this.consoleInputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleInputBox.CustomButton.UseSelectable = true;
            this.consoleInputBox.CustomButton.Visible = false;
            this.consoleInputBox.Lines = new string[0];
            this.consoleInputBox.Location = new System.Drawing.Point(8, 419);
            this.consoleInputBox.MaxLength = 32767;
            this.consoleInputBox.Name = "consoleInputBox";
            this.consoleInputBox.PasswordChar = '\0';
            this.consoleInputBox.PromptText = "Enter command";
            this.consoleInputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleInputBox.SelectedText = "";
            this.consoleInputBox.SelectionLength = 0;
            this.consoleInputBox.SelectionStart = 0;
            this.consoleInputBox.ShortcutsEnabled = true;
            this.consoleInputBox.Size = new System.Drawing.Size(653, 23);
            this.consoleInputBox.TabIndex = 2;
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
            this.consoleOutput.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.consoleOutput.CustomButton.Name = "";
            this.consoleOutput.CustomButton.Size = new System.Drawing.Size(405, 405);
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
            this.consoleOutput.Size = new System.Drawing.Size(653, 410);
            this.consoleOutput.TabIndex = 3;
            this.consoleOutput.Text = "DualSense AT - 2022 by JoseAlissonBR";
            this.consoleOutput.UseSelectable = true;
            this.consoleOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainWindow";
            this.Text = "DualSense AT";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.gamesTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.debugTab.ResumeLayout(false);
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
    }
}