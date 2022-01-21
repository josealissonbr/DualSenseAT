
namespace DualSenseAT
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.OnTime = new System.Windows.Forms.Timer(this.components);
            this.gameProcessNameLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.procOpenLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.procIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o game";
            // 
            // gameList
            // 
            this.gameList.FormattingEnabled = true;
            this.gameList.Items.AddRange(new object[] {
            "Resident Evil 5 (Steam)"});
            this.gameList.Location = new System.Drawing.Point(175, 147);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(195, 21);
            this.gameList.TabIndex = 2;
            // 
            // OnTime
            // 
            this.OnTime.Enabled = true;
            this.OnTime.Interval = 200;
            this.OnTime.Tick += new System.EventHandler(this.OnTime_Tick);
            // 
            // gameProcessNameLabel
            // 
            this.gameProcessNameLabel.AutoSize = true;
            this.gameProcessNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameProcessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameProcessNameLabel.ForeColor = System.Drawing.Color.Black;
            this.gameProcessNameLabel.Location = new System.Drawing.Point(150, 232);
            this.gameProcessNameLabel.Name = "gameProcessNameLabel";
            this.gameProcessNameLabel.Size = new System.Drawing.Size(29, 15);
            this.gameProcessNameLabel.TabIndex = 43;
            this.gameProcessNameLabel.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(3, 231);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 15);
            this.label22.TabIndex = 42;
            this.label22.Text = "Game Process Name:";
            // 
            // procOpenLabel
            // 
            this.procOpenLabel.AutoSize = true;
            this.procOpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.procOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procOpenLabel.ForeColor = System.Drawing.Color.Black;
            this.procOpenLabel.Location = new System.Drawing.Point(151, 274);
            this.procOpenLabel.Name = "procOpenLabel";
            this.procOpenLabel.Size = new System.Drawing.Size(29, 15);
            this.procOpenLabel.TabIndex = 41;
            this.procOpenLabel.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "STATUS: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Process ID: ";
            // 
            // procIdLabel
            // 
            this.procIdLabel.AutoSize = true;
            this.procIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.procIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procIdLabel.ForeColor = System.Drawing.Color.Black;
            this.procIdLabel.Location = new System.Drawing.Point(152, 252);
            this.procIdLabel.Name = "procIdLabel";
            this.procIdLabel.Size = new System.Drawing.Size(15, 15);
            this.procIdLabel.TabIndex = 38;
            this.procIdLabel.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 298);
            this.Controls.Add(this.gameProcessNameLabel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.procOpenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.procIdLabel);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DualSenseAT by José Alisson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gameList;
        private System.Windows.Forms.Timer OnTime;
        private System.Windows.Forms.Label gameProcessNameLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label procOpenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label procIdLabel;
    }
}

