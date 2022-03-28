namespace DualSenseAT
{
    partial class SplashWindow
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.finishBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.finishBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(292, 235);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(239, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(245, 209);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select your language";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishBtn.Image = global::DualSenseAT.Properties.Resources.icons8_divisa_circulada_à_direita_64;
            this.finishBtn.Location = new System.Drawing.Point(617, 409);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(64, 64);
            this.finishBtn.TabIndex = 2;
            this.finishBtn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DualSenseAT.Properties.Resources.icons8_idioma_96;
            this.pictureBox1.Location = new System.Drawing.Point(245, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 497);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroComboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashWindow";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "DualSenseAT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SplashWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finishBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox finishBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}