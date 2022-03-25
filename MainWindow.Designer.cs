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
            this.homeTab = new MetroFramework.Controls.MetroTabPage();
            this.gamesTab = new MetroFramework.Controls.MetroTabPage();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.debugTab = new MetroFramework.Controls.MetroTabPage();
            this.mainPanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
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
            this.metroTabControl1.Controls.Add(this.homeTab);
            this.metroTabControl1.Controls.Add(this.gamesTab);
            this.metroTabControl1.Controls.Add(this.settingsTab);
            this.metroTabControl1.Controls.Add(this.debugTab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(674, 418);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // homeTab
            // 
            this.homeTab.HorizontalScrollbarBarColor = true;
            this.homeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTab.HorizontalScrollbarSize = 10;
            this.homeTab.Location = new System.Drawing.Point(4, 38);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(666, 376);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.VerticalScrollbarBarColor = true;
            this.homeTab.VerticalScrollbarHighlightOnWheel = false;
            this.homeTab.VerticalScrollbarSize = 10;
            // 
            // gamesTab
            // 
            this.gamesTab.HorizontalScrollbarBarColor = true;
            this.gamesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.gamesTab.HorizontalScrollbarSize = 10;
            this.gamesTab.Location = new System.Drawing.Point(4, 38);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Size = new System.Drawing.Size(666, 376);
            this.gamesTab.TabIndex = 1;
            this.gamesTab.Text = "Games";
            this.gamesTab.VerticalScrollbarBarColor = true;
            this.gamesTab.VerticalScrollbarHighlightOnWheel = false;
            this.gamesTab.VerticalScrollbarSize = 10;
            // 
            // settingsTab
            // 
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 10;
            this.settingsTab.Location = new System.Drawing.Point(4, 38);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(666, 376);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 10;
            // 
            // debugTab
            // 
            this.debugTab.HorizontalScrollbarBarColor = true;
            this.debugTab.HorizontalScrollbarHighlightOnWheel = false;
            this.debugTab.HorizontalScrollbarSize = 10;
            this.debugTab.Location = new System.Drawing.Point(4, 38);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(666, 376);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.VerticalScrollbarBarColor = true;
            this.debugTab.VerticalScrollbarHighlightOnWheel = false;
            this.debugTab.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 498);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainWindow";
            this.Text = "DualSense AT";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainPanel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage homeTab;
        private MetroFramework.Controls.MetroTabPage gamesTab;
        private MetroFramework.Controls.MetroTabPage settingsTab;
        private MetroFramework.Controls.MetroTabPage debugTab;
    }
}