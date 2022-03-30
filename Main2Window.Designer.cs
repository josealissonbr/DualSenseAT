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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2Window));
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infoBarPanel = new System.Windows.Forms.Panel();
            this.InfoTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.SettingsTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.GamesTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.HomeTabButton = new DualSenseAT.ExtraControls.ATButton();
            this.tabsPanel.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 78);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(984, 483);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // infoBarPanel
            // 
            this.infoBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoBarPanel.Location = new System.Drawing.Point(0, 36);
            this.infoBarPanel.Name = "infoBarPanel";
            this.infoBarPanel.Size = new System.Drawing.Size(984, 42);
            this.infoBarPanel.TabIndex = 2;
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
            this.InfoTabButton.Location = new System.Drawing.Point(375, 0);
            this.InfoTabButton.Name = "InfoTabButton";
            this.InfoTabButton.Size = new System.Drawing.Size(125, 36);
            this.InfoTabButton.TabIndex = 5;
            this.InfoTabButton.Text = "InfoTabButton";
            this.InfoTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoTabButton.TextColor = System.Drawing.Color.White;
            this.InfoTabButton.UseVisualStyleBackColor = false;
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
            this.SettingsTabButton.Location = new System.Drawing.Point(250, 0);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(125, 36);
            this.SettingsTabButton.TabIndex = 4;
            this.SettingsTabButton.Text = "SettingsTabButton";
            this.SettingsTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsTabButton.TextColor = System.Drawing.Color.White;
            this.SettingsTabButton.UseVisualStyleBackColor = false;
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
            this.GamesTabButton.Location = new System.Drawing.Point(125, 0);
            this.GamesTabButton.Name = "GamesTabButton";
            this.GamesTabButton.Size = new System.Drawing.Size(125, 36);
            this.GamesTabButton.TabIndex = 3;
            this.GamesTabButton.Text = "GamesTabButton";
            this.GamesTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GamesTabButton.TextColor = System.Drawing.Color.White;
            this.GamesTabButton.UseVisualStyleBackColor = false;
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
            this.HomeTabButton.Size = new System.Drawing.Size(125, 36);
            this.HomeTabButton.TabIndex = 2;
            this.HomeTabButton.Text = "HomeTabButton";
            this.HomeTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeTabButton.TextColor = System.Drawing.Color.White;
            this.HomeTabButton.UseVisualStyleBackColor = false;
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
            this.Load += new System.EventHandler(this.Main2Window_Load);
            this.tabsPanel.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabsPanel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel infoBarPanel;
        private ExtraControls.ATButton HomeTabButton;
        private ExtraControls.ATButton GamesTabButton;
        private ExtraControls.ATButton SettingsTabButton;
        private ExtraControls.ATButton InfoTabButton;
    }
}