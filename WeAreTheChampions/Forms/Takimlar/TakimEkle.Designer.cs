
namespace WeAreTheChampions.Forms.Takimlar
{
    partial class TakimEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakimEkleTakimAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboTakimEkleTakimRenk = new System.Windows.Forms.ComboBox();
            this.btnTakimEkleTakimEkle = new System.Windows.Forms.Button();
            this.lstTakimEkleTakimRenkler = new System.Windows.Forms.ListBox();
            this.btnTakimEkleTakimRenkEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım Adı";
            // 
            // txtTakimEkleTakimAd
            // 
            this.txtTakimEkleTakimAd.BackColor = System.Drawing.Color.White;
            this.txtTakimEkleTakimAd.Location = new System.Drawing.Point(14, 52);
            this.txtTakimEkleTakimAd.Name = "txtTakimEkleTakimAd";
            this.txtTakimEkleTakimAd.Size = new System.Drawing.Size(364, 27);
            this.txtTakimEkleTakimAd.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım Rengi";
            // 
            // cboTakimEkleTakimRenk
            // 
            this.cboTakimEkleTakimRenk.BackColor = System.Drawing.Color.White;
            this.cboTakimEkleTakimRenk.FormattingEnabled = true;
            this.cboTakimEkleTakimRenk.Location = new System.Drawing.Point(14, 172);
            this.cboTakimEkleTakimRenk.Name = "cboTakimEkleTakimRenk";
            this.cboTakimEkleTakimRenk.Size = new System.Drawing.Size(205, 27);
            this.cboTakimEkleTakimRenk.TabIndex = 4;
            // 
            // btnTakimEkleTakimEkle
            // 
            this.btnTakimEkleTakimEkle.BackColor = System.Drawing.Color.White;
            this.btnTakimEkleTakimEkle.Location = new System.Drawing.Point(14, 384);
            this.btnTakimEkleTakimEkle.Name = "btnTakimEkleTakimEkle";
            this.btnTakimEkleTakimEkle.Size = new System.Drawing.Size(364, 37);
            this.btnTakimEkleTakimEkle.TabIndex = 9;
            this.btnTakimEkleTakimEkle.Text = "Yeni Takim Ekle";
            this.btnTakimEkleTakimEkle.UseVisualStyleBackColor = false;
            this.btnTakimEkleTakimEkle.Click += new System.EventHandler(this.btnTakimEkleTakimEkle_Click);
            // 
            // lstTakimEkleTakimRenkler
            // 
            this.lstTakimEkleTakimRenkler.FormattingEnabled = true;
            this.lstTakimEkleTakimRenkler.ItemHeight = 19;
            this.lstTakimEkleTakimRenkler.Location = new System.Drawing.Point(14, 218);
            this.lstTakimEkleTakimRenkler.Name = "lstTakimEkleTakimRenkler";
            this.lstTakimEkleTakimRenkler.Size = new System.Drawing.Size(364, 118);
            this.lstTakimEkleTakimRenkler.TabIndex = 10;
            // 
            // btnTakimEkleTakimRenkEkle
            // 
            this.btnTakimEkleTakimRenkEkle.BackColor = System.Drawing.Color.White;
            this.btnTakimEkleTakimRenkEkle.Location = new System.Drawing.Point(252, 170);
            this.btnTakimEkleTakimRenkEkle.Name = "btnTakimEkleTakimRenkEkle";
            this.btnTakimEkleTakimRenkEkle.Size = new System.Drawing.Size(126, 28);
            this.btnTakimEkleTakimRenkEkle.TabIndex = 11;
            this.btnTakimEkleTakimRenkEkle.Text = "Renk Ekle";
            this.btnTakimEkleTakimRenkEkle.UseVisualStyleBackColor = false;
            this.btnTakimEkleTakimRenkEkle.Click += new System.EventHandler(this.btnTakimEkleTakimRenkEkle_Click);
            // 
            // TakimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(405, 477);
            this.Controls.Add(this.btnTakimEkleTakimRenkEkle);
            this.Controls.Add(this.lstTakimEkleTakimRenkler);
            this.Controls.Add(this.btnTakimEkleTakimEkle);
            this.Controls.Add(this.cboTakimEkleTakimRenk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTakimEkleTakimAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TakimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TakimEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTakimEkleTakimAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTakimEkleTakimRenk;
        private System.Windows.Forms.Button btnTakimEkleTakimEkle;
        private System.Windows.Forms.ListBox lstTakimEkleTakimRenkler;
        private System.Windows.Forms.Button btnTakimEkleTakimRenkEkle;
    }
}