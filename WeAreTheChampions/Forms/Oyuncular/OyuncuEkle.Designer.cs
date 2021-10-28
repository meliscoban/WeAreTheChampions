
namespace WeAreTheChampions.Forms.Oyuncular
{
    partial class OyuncuEkle
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
            this.btnOyuncuEkleOyuncuEkle = new System.Windows.Forms.Button();
            this.txtOyuncuEkleOyuncuAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOyuncuEkleTakimAd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOyuncuEkleOyuncuEkle
            // 
            this.btnOyuncuEkleOyuncuEkle.BackColor = System.Drawing.Color.White;
            this.btnOyuncuEkleOyuncuEkle.Location = new System.Drawing.Point(16, 183);
            this.btnOyuncuEkleOyuncuEkle.Name = "btnOyuncuEkleOyuncuEkle";
            this.btnOyuncuEkleOyuncuEkle.Size = new System.Drawing.Size(397, 37);
            this.btnOyuncuEkleOyuncuEkle.TabIndex = 23;
            this.btnOyuncuEkleOyuncuEkle.Text = "Yeni Oyuncu Ekle";
            this.btnOyuncuEkleOyuncuEkle.UseVisualStyleBackColor = false;
            this.btnOyuncuEkleOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkleOyuncuEkle_Click);
            // 
            // txtOyuncuEkleOyuncuAd
            // 
            this.txtOyuncuEkleOyuncuAd.Location = new System.Drawing.Point(16, 31);
            this.txtOyuncuEkleOyuncuAd.Name = "txtOyuncuEkleOyuncuAd";
            this.txtOyuncuEkleOyuncuAd.Size = new System.Drawing.Size(397, 27);
            this.txtOyuncuEkleOyuncuAd.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Oyuncu Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Takım Adı";
            // 
            // cboOyuncuEkleTakimAd
            // 
            this.cboOyuncuEkleTakimAd.FormattingEnabled = true;
            this.cboOyuncuEkleTakimAd.Location = new System.Drawing.Point(16, 112);
            this.cboOyuncuEkleTakimAd.Name = "cboOyuncuEkleTakimAd";
            this.cboOyuncuEkleTakimAd.Size = new System.Drawing.Size(397, 27);
            this.cboOyuncuEkleTakimAd.TabIndex = 26;
            // 
            // OyuncuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(433, 238);
            this.Controls.Add(this.cboOyuncuEkleTakimAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOyuncuEkleOyuncuEkle);
            this.Controls.Add(this.txtOyuncuEkleOyuncuAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OyuncuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OyuncuEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyuncuEkleOyuncuEkle;
        private System.Windows.Forms.TextBox txtOyuncuEkleOyuncuAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOyuncuEkleTakimAd;
    }
}