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
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.gamesTab = new MetroFramework.Controls.MetroTabPage();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.debugTab = new MetroFramework.Controls.MetroTabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.consoleInputBox = new MetroFramework.Controls.MetroTextBox();
            this.consoleOutput = new MetroFramework.Controls.MetroTextBox();
            this.mainPanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.gamesTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.metroTabControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(674, 418);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.gamesTab);
            this.metroTabControl1.Controls.Add(this.settingsTab);
            this.metroTabControl1.Controls.Add(this.debugTab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(674, 418);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.metroPanel1);
            this.gamesTab.Controls.Add(this.listBox1);
            this.gamesTab.HorizontalScrollbarBarColor = true;
            this.gamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.gamesTab.HorizontalScrollbarSize = 10;
            this.gamesTab.Location = new System.Drawing.Point(4, 41);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Size = new System.Drawing.Size(666, 373);
            this.gamesTab.TabIndex = 0;
            this.gamesTab.Text = "Games";
            this.gamesTab.VerticalScrollbarBarColor = true;
            this.gamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.gamesTab.VerticalScrollbarSize = 10;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.settingsTab.Controls.Add(this.panel2);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 41);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(666, 373);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.panel3);
            this.debugTab.HorizontalScrollbarBarColor = true;
            this.debugTab.HorizontalScrollbarHighlightOnWheel = false;
            this.debugTab.HorizontalScrollbarSize = 10;
            this.debugTab.Location = new System.Drawing.Point(4, 41);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(666, 373);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.VerticalScrollbarBarColor = true;
            this.debugTab.VerticalScrollbarHighlightOnWheel = false;
            this.debugTab.VerticalScrollbarSize = 10;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Teste1",
            "Teste1",
            "Teste1",
            "Teste1",
            "Teste1"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MinimumSize = new System.Drawing.Size(208, 373);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 373);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 373);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.consoleOutput);
            this.panel3.Controls.Add(this.consoleInputBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 373);
            this.panel3.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(208, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(458, 373);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // consoleInputBox
            // 
            // 
            // 
            // 
            this.consoleInputBox.CustomButton.Image = null;
            this.consoleInputBox.CustomButton.Location = new System.Drawing.Point(644, 1);
            this.consoleInputBox.CustomButton.Name = "";
            this.consoleInputBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.consoleInputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleInputBox.CustomButton.TabIndex = 1;
            this.consoleInputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleInputBox.CustomButton.UseSelectable = true;
            this.consoleInputBox.CustomButton.Visible = false;
            this.consoleInputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleInputBox.Lines = new string[0];
            this.consoleInputBox.Location = new System.Drawing.Point(0, 350);
            this.consoleInputBox.MaxLength = 32767;
            this.consoleInputBox.Name = "consoleInputBox";
            this.consoleInputBox.PasswordChar = '\0';
            this.consoleInputBox.PromptText = "Enter commands";
            this.consoleInputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleInputBox.SelectedText = "";
            this.consoleInputBox.SelectionLength = 0;
            this.consoleInputBox.SelectionStart = 0;
            this.consoleInputBox.ShortcutsEnabled = false;
            this.consoleInputBox.Size = new System.Drawing.Size(666, 23);
            this.consoleInputBox.TabIndex = 0;
            this.consoleInputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.consoleInputBox.UseSelectable = true;
            this.consoleInputBox.WaterMark = "Enter commands";
            this.consoleInputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleInputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.consoleInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // consoleOutput
            // 
            // 
            // 
            // 
            this.consoleOutput.CustomButton.Image = null;
            this.consoleOutput.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.consoleOutput.CustomButton.Name = "";
            this.consoleOutput.CustomButton.Size = new System.Drawing.Size(345, 345);
            this.consoleOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleOutput.CustomButton.TabIndex = 1;
            this.consoleOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleOutput.CustomButton.UseSelectable = true;
            this.consoleOutput.CustomButton.Visible = false;
            this.consoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutput.Lines = new string[0];
            this.consoleOutput.Location = new System.Drawing.Point(0, 0);
            this.consoleOutput.MaxLength = 32767;
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.PasswordChar = '\0';
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consoleOutput.SelectedText = "";
            this.consoleOutput.SelectionLength = 0;
            this.consoleOutput.SelectionStart = 0;
            this.consoleOutput.ShortcutsEnabled = true;
            this.consoleOutput.Size = new System.Drawing.Size(666, 350);
            this.consoleOutput.TabIndex = 1;
            this.consoleOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.consoleOutput.UseSelectable = true;
            this.consoleOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 498);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(714, 498);
            this.Name = "MainWindow";
            this.Text = "DualSense AT";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainPanel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.gamesTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.debugTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage gamesTab;
        private MetroFramework.Controls.MetroTabPage settingsTab;
        private MetroFramework.Controls.MetroTabPage debugTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox consoleInputBox;
        private MetroFramework.Controls.MetroTextBox consoleOutput;
    }
}