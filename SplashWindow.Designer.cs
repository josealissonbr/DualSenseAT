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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashWindow));
            this.TitleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.EveryTick = new System.Windows.Forms.Timer(this.components);
            this.checkUpdates = new System.ComponentModel.BackgroundWorker();
            this.UpdateLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Hind", 42.25F, System.Drawing.FontStyle.Bold);
            this.TitleLbl.Location = new System.Drawing.Point(306, 55);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(373, 91);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "DualSenseAT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DualSenseAT.Properties.Resources.fg;
            this.pictureBox1.Location = new System.Drawing.Point(277, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(306, 404);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(373, 10);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EveryTick
            // 
            this.EveryTick.Tick += new System.EventHandler(this.EveryTick_Tick);
            // 
            // checkUpdates
            // 
            this.checkUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkUpdates_DoWork);
            this.checkUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkUpdates_RunWorkerCompleted);
            // 
            // UpdateLbl
            // 
            this.UpdateLbl.AutoSize = true;
            this.UpdateLbl.Location = new System.Drawing.Point(423, 382);
            this.UpdateLbl.Name = "UpdateLbl";
            this.UpdateLbl.Size = new System.Drawing.Size(123, 19);
            this.UpdateLbl.TabIndex = 3;
            this.UpdateLbl.Text = "Checking Updates...";
            this.UpdateLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.UpdateLbl);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "SplashWindow";
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
            this.Load += new System.EventHandler(this.SplashWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer EveryTick;
        private System.ComponentModel.BackgroundWorker checkUpdates;
        private MetroFramework.Controls.MetroLabel UpdateLbl;
    }
}