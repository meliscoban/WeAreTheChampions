
namespace WeAreTheChampions.Forms.Oyuncular
{
    partial class OyuncuDuzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOyuncuDuzenleOyuncuEkle = new System.Windows.Forms.Button();
            this.txtOyuncuDuzenleOyuncuAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOyuncuDuzenleTakimAd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Takım Adı";
            // 
            // btnOyuncuDuzenleOyuncuEkle
            // 
            this.btnOyuncuDuzenleOyuncuEkle.BackColor = System.Drawing.Color.White;
            this.btnOyuncuDuzenleOyuncuEkle.Location = new System.Drawing.Point(16, 183);
            this.btnOyuncuDuzenleOyuncuEkle.Name = "btnOyuncuDuzenleOyuncuEkle";
            this.btnOyuncuDuzenleOyuncuEkle.Size = new System.Drawing.Size(397, 37);
            this.btnOyuncuDuzenleOyuncuEkle.TabIndex = 28;
            this.btnOyuncuDuzenleOyuncuEkle.Text = "Oyuncuyu Duzenle";
            this.btnOyuncuDuzenleOyuncuEkle.UseVisualStyleBackColor = false;
            this.btnOyuncuDuzenleOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuDuzenleOyuncuEkle_Click);
            // 
            // txtOyuncuDuzenleOyuncuAd
            // 
            this.txtOyuncuDuzenleOyuncuAd.Location = new System.Drawing.Point(16, 31);
            this.txtOyuncuDuzenleOyuncuAd.Name = "txtOyuncuDuzenleOyuncuAd";
            this.txtOyuncuDuzenleOyuncuAd.Size = new System.Drawing.Size(397, 27);
            this.txtOyuncuDuzenleOyuncuAd.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Oyuncu Adı";
            // 
            // cboOyuncuDuzenleTakimAd
            // 
            this.cboOyuncuDuzenleTakimAd.FormattingEnabled = true;
            this.cboOyuncuDuzenleTakimAd.Location = new System.Drawing.Point(16, 112);
            this.cboOyuncuDuzenleTakimAd.Name = "cboOyuncuDuzenleTakimAd";
            this.cboOyuncuDuzenleTakimAd.Size = new System.Drawing.Size(397, 27);
            this.cboOyuncuDuzenleTakimAd.TabIndex = 31;
            // 
            // OyuncuDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(433, 238);
            this.Controls.Add(this.cboOyuncuDuzenleTakimAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOyuncuDuzenleOyuncuEkle);
            this.Controls.Add(this.txtOyuncuDuzenleOyuncuAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OyuncuDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncuDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOyuncuDuzenleOyuncuEkle;
        private System.Windows.Forms.TextBox txtOyuncuDuzenleOyuncuAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOyuncuDuzenleTakimAd;
    }
}