
namespace WeAreTheChampions.Forms.Renkler
{
    partial class RenkEkle
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
            this.btnRenkEkleRenkEkle = new System.Windows.Forms.Button();
            this.txtRenkEkleRenkAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRenkEkleKirmizi = new System.Windows.Forms.NumericUpDown();
            this.nudRenkEkleMavi = new System.Windows.Forms.NumericUpDown();
            this.nudRenkEkleYesil = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleKirmizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleYesil)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "RGB Değerleri";
            // 
            // btnRenkEkleRenkEkle
            // 
            this.btnRenkEkleRenkEkle.BackColor = System.Drawing.Color.White;
            this.btnRenkEkleRenkEkle.Location = new System.Drawing.Point(16, 202);
            this.btnRenkEkleRenkEkle.Name = "btnRenkEkleRenkEkle";
            this.btnRenkEkleRenkEkle.Size = new System.Drawing.Size(397, 37);
            this.btnRenkEkleRenkEkle.TabIndex = 28;
            this.btnRenkEkleRenkEkle.Text = "Yeni Renk Ekle";
            this.btnRenkEkleRenkEkle.UseVisualStyleBackColor = false;
            this.btnRenkEkleRenkEkle.Click += new System.EventHandler(this.btnRenkEkleRenkEkle_Click);
            // 
            // txtRenkEkleRenkAd
            // 
            this.txtRenkEkleRenkAd.Location = new System.Drawing.Point(16, 31);
            this.txtRenkEkleRenkAd.Name = "txtRenkEkleRenkAd";
            this.txtRenkEkleRenkAd.Size = new System.Drawing.Size(397, 27);
            this.txtRenkEkleRenkAd.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Renk Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kırmızı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Yeşil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mavi";
            // 
            // nudRenkEkleKirmizi
            // 
            this.nudRenkEkleKirmizi.Location = new System.Drawing.Point(16, 142);
            this.nudRenkEkleKirmizi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkEkleKirmizi.Name = "nudRenkEkleKirmizi";
            this.nudRenkEkleKirmizi.Size = new System.Drawing.Size(115, 27);
            this.nudRenkEkleKirmizi.TabIndex = 36;
            // 
            // nudRenkEkleMavi
            // 
            this.nudRenkEkleMavi.Location = new System.Drawing.Point(298, 142);
            this.nudRenkEkleMavi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkEkleMavi.Name = "nudRenkEkleMavi";
            this.nudRenkEkleMavi.Size = new System.Drawing.Size(115, 27);
            this.nudRenkEkleMavi.TabIndex = 37;
            // 
            // nudRenkEkleYesil
            // 
            this.nudRenkEkleYesil.Location = new System.Drawing.Point(157, 142);
            this.nudRenkEkleYesil.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkEkleYesil.Name = "nudRenkEkleYesil";
            this.nudRenkEkleYesil.Size = new System.Drawing.Size(115, 27);
            this.nudRenkEkleYesil.TabIndex = 38;
            // 
            // RenkEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(433, 250);
            this.Controls.Add(this.nudRenkEkleYesil);
            this.Controls.Add(this.nudRenkEkleMavi);
            this.Controls.Add(this.nudRenkEkleKirmizi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRenkEkleRenkEkle);
            this.Controls.Add(this.txtRenkEkleRenkAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RenkEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RenkEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleKirmizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkEkleYesil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenkEkleRenkEkle;
        private System.Windows.Forms.TextBox txtRenkEkleRenkAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRenkEkleKirmizi;
        private System.Windows.Forms.NumericUpDown nudRenkEkleMavi;
        private System.Windows.Forms.NumericUpDown nudRenkEkleYesil;
    }
}