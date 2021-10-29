
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
            this.btnTakimDuzenleTakimDuzenle = new System.Windows.Forms.Button();
            this.txtTakimDuzenleTakimAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cklTakimDuzenleRenkler = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnTakimDuzenleTakimDuzenle
            // 
            this.btnTakimDuzenleTakimDuzenle.BackColor = System.Drawing.Color.White;
            this.btnTakimDuzenleTakimDuzenle.Location = new System.Drawing.Point(16, 316);
            this.btnTakimDuzenleTakimDuzenle.Name = "btnTakimDuzenleTakimDuzenle";
            this.btnTakimDuzenleTakimDuzenle.Size = new System.Drawing.Size(364, 37);
            this.btnTakimDuzenleTakimDuzenle.TabIndex = 16;
            this.btnTakimDuzenleTakimDuzenle.Text = "Takımı Düzenle";
            this.btnTakimDuzenleTakimDuzenle.UseVisualStyleBackColor = false;
            this.btnTakimDuzenleTakimDuzenle.Click += new System.EventHandler(this.btnTakimDuzenleTakimDuzenle_Click);
            // 
            // txtTakimDuzenleTakimAd
            // 
            this.txtTakimDuzenleTakimAd.BackColor = System.Drawing.Color.White;
            this.txtTakimDuzenleTakimAd.Location = new System.Drawing.Point(16, 31);
            this.txtTakimDuzenleTakimAd.Name = "txtTakimDuzenleTakimAd";
            this.txtTakimDuzenleTakimAd.Size = new System.Drawing.Size(365, 27);
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
            // cklTakimDuzenleRenkler
            // 
            this.cklTakimDuzenleRenkler.FormattingEnabled = true;
            this.cklTakimDuzenleRenkler.Location = new System.Drawing.Point(16, 64);
            this.cklTakimDuzenleRenkler.Name = "cklTakimDuzenleRenkler";
            this.cklTakimDuzenleRenkler.Size = new System.Drawing.Size(364, 246);
            this.cklTakimDuzenleRenkler.TabIndex = 17;
            // 
            // TakimDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 366);
            this.Controls.Add(this.cklTakimDuzenleRenkler);
            this.Controls.Add(this.btnTakimDuzenleTakimDuzenle);
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
        private System.Windows.Forms.Button btnTakimDuzenleTakimDuzenle;
        private System.Windows.Forms.TextBox txtTakimDuzenleTakimAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cklTakimDuzenleRenkler;
    }
}