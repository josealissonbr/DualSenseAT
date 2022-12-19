namespace DualSenseAT.V2.components
{
    partial class game_icon_fragment
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.loadContent = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 14;
            this.guna2Panel2.Controls.Add(this.guna2RatingStar1);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton8);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(165, 224);
            this.guna2Panel2.TabIndex = 18;
            this.guna2Panel2.Click += new System.EventHandler(this.guna2Panel2_Click);
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2RatingStar1.Location = new System.Drawing.Point(21, 136);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2RatingStar1.Size = new System.Drawing.Size(99, 25);
            this.guna2RatingStar1.TabIndex = 15;
            this.guna2RatingStar1.Value = 4F;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Working";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 99);
            this.label10.MaximumSize = new System.Drawing.Size(165, 20);
            this.label10.MinimumSize = new System.Drawing.Size(165, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 13;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.CheckedState.Parent = this.guna2ImageButton8;
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(65, 65);
            this.guna2ImageButton8.HoverState.Parent = this.guna2ImageButton8;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2ImageButton8.Location = new System.Drawing.Point(44, 19);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.PressedState.Parent = this.guna2ImageButton8;
            this.guna2ImageButton8.Size = new System.Drawing.Size(74, 67);
            this.guna2ImageButton8.TabIndex = 12;
            this.guna2ImageButton8.UseTransparentBackground = true;
            // 
            // loadContent
            // 
            this.loadContent.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadContent_DoWork);
            this.loadContent.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadContent_RunWorkerCompleted);
            // 
            // game_icon_fragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Name = "game_icon_fragment";
            this.Size = new System.Drawing.Size(165, 224);
            this.Load += new System.EventHandler(this.game_icon_fragment_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
        private System.ComponentModel.BackgroundWorker loadContent;
    }
}
