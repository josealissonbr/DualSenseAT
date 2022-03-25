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
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(706, 426);
            this.metroTabControl2.TabIndex = 0;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(192, 58);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(698, 384);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(706, 426);
            this.Controls.Add(this.metroTabControl2);
            this.Name = "MainWindow";
            this.metroTabControl2.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}