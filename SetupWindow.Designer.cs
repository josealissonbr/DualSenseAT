namespace DualSenseAT
{
    partial class SetupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWindow));
            this.TitleLbl = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.atButton1 = new DualSenseAT.ExtraControls.ATButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBox1.ForeColor = System.Drawing.Color.White;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(363, 406);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(301, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(363, 384);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Select your language";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DualSenseAT.Properties.Resources.language_24px;
            this.pictureBox2.Location = new System.Drawing.Point(332, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 31);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // atButton1
            // 
            this.atButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.atButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.atButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.atButton1.BorderRadius = 6;
            this.atButton1.BorderSize = 0;
            this.atButton1.FlatAppearance.BorderSize = 0;
            this.atButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atButton1.ForeColor = System.Drawing.Color.White;
            this.atButton1.Image = global::DualSenseAT.Properties.Resources.ok_26px;
            this.atButton1.Location = new System.Drawing.Point(781, 470);
            this.atButton1.Name = "atButton1";
            this.atButton1.Size = new System.Drawing.Size(152, 60);
            this.atButton1.TabIndex = 2;
            this.atButton1.TextColor = System.Drawing.Color.White;
            this.atButton1.UseVisualStyleBackColor = false;
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
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.atButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "SetupWindow";
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
            this.Text = "DualSense AT v0.1 Setup";
            this.Load += new System.EventHandler(this.SetupWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExtraControls.ATButton atButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}