
namespace WeAreTheChampions.Forms.Takimlar
{
    partial class TakimOyunculari
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
            this.dgvTakimOyunculariOyuncular = new System.Windows.Forms.DataGridView();
            this.cboTakimOyunculariOyuncular = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakimOyunculariOyuncuEkle = new System.Windows.Forms.Button();
            this.lblTakimOyunculariTakimAd = new System.Windows.Forms.Label();
            this.btnTakimOyunculariOyuncuSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimOyunculariOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakimOyunculariOyuncular
            // 
            this.dgvTakimOyunculariOyuncular.BackgroundColor = System.Drawing.Color.White;
            this.dgvTakimOyunculariOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakimOyunculariOyuncular.Location = new System.Drawing.Point(14, 203);
            this.dgvTakimOyunculariOyuncular.Name = "dgvTakimOyunculariOyuncular";
            this.dgvTakimOyunculariOyuncular.Size = new System.Drawing.Size(517, 245);
            this.dgvTakimOyunculariOyuncular.TabIndex = 0;
            // 
            // cboTakimOyunculariOyuncular
            // 
            this.cboTakimOyunculariOyuncular.BackColor = System.Drawing.Color.White;
            this.cboTakimOyunculariOyuncular.FormattingEnabled = true;
            this.cboTakimOyunculariOyuncular.Location = new System.Drawing.Point(14, 75);
            this.cboTakimOyunculariOyuncular.Name = "cboTakimOyunculariOyuncular";
            this.cboTakimOyunculariOyuncular.Size = new System.Drawing.Size(290, 27);
            this.cboTakimOyunculariOyuncular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oyuncular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takımının Oyuncuları";
            // 
            // btnTakimOyunculariOyuncuEkle
            // 
            this.btnTakimOyunculariOyuncuEkle.BackColor = System.Drawing.Color.White;
            this.btnTakimOyunculariOyuncuEkle.Location = new System.Drawing.Point(333, 75);
            this.btnTakimOyunculariOyuncuEkle.Name = "btnTakimOyunculariOyuncuEkle";
            this.btnTakimOyunculariOyuncuEkle.Size = new System.Drawing.Size(189, 27);
            this.btnTakimOyunculariOyuncuEkle.TabIndex = 4;
            this.btnTakimOyunculariOyuncuEkle.Text = "Takıma Oyuncu Ekle";
            this.btnTakimOyunculariOyuncuEkle.UseVisualStyleBackColor = false;
            // 
            // lblTakimOyunculariTakimAd
            // 
            this.lblTakimOyunculariTakimAd.AutoSize = true;
            this.lblTakimOyunculariTakimAd.Location = new System.Drawing.Point(11, 145);
            this.lblTakimOyunculariTakimAd.Name = "lblTakimOyunculariTakimAd";
            this.lblTakimOyunculariTakimAd.Size = new System.Drawing.Size(72, 19);
            this.lblTakimOyunculariTakimAd.TabIndex = 5;
            this.lblTakimOyunculariTakimAd.Text = "TakımAdı";
            // 
            // btnTakimOyunculariOyuncuSil
            // 
            this.btnTakimOyunculariOyuncuSil.BackColor = System.Drawing.Color.White;
            this.btnTakimOyunculariOyuncuSil.Location = new System.Drawing.Point(343, 454);
            this.btnTakimOyunculariOyuncuSil.Name = "btnTakimOyunculariOyuncuSil";
            this.btnTakimOyunculariOyuncuSil.Size = new System.Drawing.Size(189, 27);
            this.btnTakimOyunculariOyuncuSil.TabIndex = 6;
            this.btnTakimOyunculariOyuncuSil.Text = "Oyuncuyu Sil";
            this.btnTakimOyunculariOyuncuSil.UseVisualStyleBackColor = false;
            this.btnTakimOyunculariOyuncuSil.Click += new System.EventHandler(this.btnTakimOyunculariOyuncuSil_Click);
            // 
            // TakimOyunculari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(560, 502);
            this.Controls.Add(this.btnTakimOyunculariOyuncuSil);
            this.Controls.Add(this.lblTakimOyunculariTakimAd);
            this.Controls.Add(this.btnTakimOyunculariOyuncuEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTakimOyunculariOyuncular);
            this.Controls.Add(this.dgvTakimOyunculariOyuncular);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimOyunculari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimOyunculari";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimOyunculariOyuncular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakimOyunculariOyuncular;
        private System.Windows.Forms.ComboBox cboTakimOyunculariOyuncular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakimOyunculariOyuncuEkle;
        private System.Windows.Forms.Label lblTakimOyunculariTakimAd;
        private System.Windows.Forms.Button btnTakimOyunculariOyuncuSil;
    }
}