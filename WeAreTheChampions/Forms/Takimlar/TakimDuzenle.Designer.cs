
namespace WeAreTheChampions.Forms.Takimlar
{
    partial class TakimDuzenle
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
            this.btnTakimDuzenleTakimRenkEkle = new System.Windows.Forms.Button();
            this.lstTakimDuzenleTakimRenkler = new System.Windows.Forms.ListBox();
            this.btnTakimDuzenleTakimDuzenle = new System.Windows.Forms.Button();
            this.cboTakimDuzenleTakimRenk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTakimDuzenleTakimAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTakimDuzenleTakimRenkEkle
            // 
            this.btnTakimDuzenleTakimRenkEkle.BackColor = System.Drawing.Color.White;
            this.btnTakimDuzenleTakimRenkEkle.Location = new System.Drawing.Point(256, 168);
            this.btnTakimDuzenleTakimRenkEkle.Name = "btnTakimDuzenleTakimRenkEkle";
            this.btnTakimDuzenleTakimRenkEkle.Size = new System.Drawing.Size(126, 28);
            this.btnTakimDuzenleTakimRenkEkle.TabIndex = 18;
            this.btnTakimDuzenleTakimRenkEkle.Text = "Renk Ekle";
            this.btnTakimDuzenleTakimRenkEkle.UseVisualStyleBackColor = false;
            // 
            // lstTakimDuzenleTakimRenkler
            // 
            this.lstTakimDuzenleTakimRenkler.FormattingEnabled = true;
            this.lstTakimDuzenleTakimRenkler.ItemHeight = 19;
            this.lstTakimDuzenleTakimRenkler.Location = new System.Drawing.Point(19, 217);
            this.lstTakimDuzenleTakimRenkler.Name = "lstTakimDuzenleTakimRenkler";
            this.lstTakimDuzenleTakimRenkler.Size = new System.Drawing.Size(364, 118);
            this.lstTakimDuzenleTakimRenkler.TabIndex = 17;
            // 
            // btnTakimDuzenleTakimDuzenle
            // 
            this.btnTakimDuzenleTakimDuzenle.BackColor = System.Drawing.Color.White;
            this.btnTakimDuzenleTakimDuzenle.Location = new System.Drawing.Point(19, 382);
            this.btnTakimDuzenleTakimDuzenle.Name = "btnTakimDuzenleTakimDuzenle";
            this.btnTakimDuzenleTakimDuzenle.Size = new System.Drawing.Size(364, 37);
            this.btnTakimDuzenleTakimDuzenle.TabIndex = 16;
            this.btnTakimDuzenleTakimDuzenle.Text = "Yeni Takim Ekle";
            this.btnTakimDuzenleTakimDuzenle.UseVisualStyleBackColor = false;
            this.btnTakimDuzenleTakimDuzenle.Click += new System.EventHandler(this.btnTakimDuzenleTakimDuzenle_Click);
            // 
            // cboTakimDuzenleTakimRenk
            // 
            this.cboTakimDuzenleTakimRenk.BackColor = System.Drawing.Color.White;
            this.cboTakimDuzenleTakimRenk.FormattingEnabled = true;
            this.cboTakimDuzenleTakimRenk.Location = new System.Drawing.Point(19, 170);
            this.cboTakimDuzenleTakimRenk.Name = "cboTakimDuzenleTakimRenk";
            this.cboTakimDuzenleTakimRenk.Size = new System.Drawing.Size(205, 27);
            this.cboTakimDuzenleTakimRenk.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Takım Rengi";
            // 
            // txtTakimDuzenleTakimAd
            // 
            this.txtTakimDuzenleTakimAd.BackColor = System.Drawing.Color.White;
            this.txtTakimDuzenleTakimAd.Location = new System.Drawing.Point(19, 50);
            this.txtTakimDuzenleTakimAd.Name = "txtTakimDuzenleTakimAd";
            this.txtTakimDuzenleTakimAd.Size = new System.Drawing.Size(364, 27);
            this.txtTakimDuzenleTakimAd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Takım Adı";
            // 
            // TakimDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(421, 482);
            this.Controls.Add(this.btnTakimDuzenleTakimRenkEkle);
            this.Controls.Add(this.lstTakimDuzenleTakimRenkler);
            this.Controls.Add(this.btnTakimDuzenleTakimDuzenle);
            this.Controls.Add(this.cboTakimDuzenleTakimRenk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTakimDuzenleTakimAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakimDuzenleTakimRenkEkle;
        private System.Windows.Forms.ListBox lstTakimDuzenleTakimRenkler;
        private System.Windows.Forms.Button btnTakimDuzenleTakimDuzenle;
        private System.Windows.Forms.ComboBox cboTakimDuzenleTakimRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTakimDuzenleTakimAd;
        private System.Windows.Forms.Label label1;
    }
}