
namespace WeAreTheChampions.Forms.Renkler
{
    partial class RenkDuzenle
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRenkDuzenleRenkDuzenle = new System.Windows.Forms.Button();
            this.txtRenkDuzenleRenkAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRenkDuzenleYesil = new System.Windows.Forms.NumericUpDown();
            this.nudRenkDuzenleMavi = new System.Windows.Forms.NumericUpDown();
            this.nudRenkDuzenleKirmizi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleYesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleKirmizi)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Mavi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Yeşil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kırmızı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "RGB Değerleri";
            // 
            // btnRenkDuzenleRenkDuzenle
            // 
            this.btnRenkDuzenleRenkDuzenle.BackColor = System.Drawing.Color.White;
            this.btnRenkDuzenleRenkDuzenle.Location = new System.Drawing.Point(16, 202);
            this.btnRenkDuzenleRenkDuzenle.Name = "btnRenkDuzenleRenkDuzenle";
            this.btnRenkDuzenleRenkDuzenle.Size = new System.Drawing.Size(397, 37);
            this.btnRenkDuzenleRenkDuzenle.TabIndex = 38;
            this.btnRenkDuzenleRenkDuzenle.Text = "Rengi Düzenle";
            this.btnRenkDuzenleRenkDuzenle.UseVisualStyleBackColor = false;
            this.btnRenkDuzenleRenkDuzenle.Click += new System.EventHandler(this.btnRenkDuzenleRenkDuzenle_Click);
            // 
            // txtRenkDuzenleRenkAd
            // 
            this.txtRenkDuzenleRenkAd.Location = new System.Drawing.Point(16, 31);
            this.txtRenkDuzenleRenkAd.Name = "txtRenkDuzenleRenkAd";
            this.txtRenkDuzenleRenkAd.Size = new System.Drawing.Size(397, 27);
            this.txtRenkDuzenleRenkAd.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Renk Adı";
            // 
            // nudRenkDuzenleYesil
            // 
            this.nudRenkDuzenleYesil.Location = new System.Drawing.Point(157, 142);
            this.nudRenkDuzenleYesil.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkDuzenleYesil.Name = "nudRenkDuzenleYesil";
            this.nudRenkDuzenleYesil.Size = new System.Drawing.Size(115, 27);
            this.nudRenkDuzenleYesil.TabIndex = 48;
            // 
            // nudRenkDuzenleMavi
            // 
            this.nudRenkDuzenleMavi.Location = new System.Drawing.Point(298, 142);
            this.nudRenkDuzenleMavi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkDuzenleMavi.Name = "nudRenkDuzenleMavi";
            this.nudRenkDuzenleMavi.Size = new System.Drawing.Size(115, 27);
            this.nudRenkDuzenleMavi.TabIndex = 47;
            // 
            // nudRenkDuzenleKirmizi
            // 
            this.nudRenkDuzenleKirmizi.Location = new System.Drawing.Point(16, 142);
            this.nudRenkDuzenleKirmizi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRenkDuzenleKirmizi.Name = "nudRenkDuzenleKirmizi";
            this.nudRenkDuzenleKirmizi.Size = new System.Drawing.Size(115, 27);
            this.nudRenkDuzenleKirmizi.TabIndex = 46;
            // 
            // RenkDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(433, 250);
            this.Controls.Add(this.nudRenkDuzenleYesil);
            this.Controls.Add(this.nudRenkDuzenleMavi);
            this.Controls.Add(this.nudRenkDuzenleKirmizi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRenkDuzenleRenkDuzenle);
            this.Controls.Add(this.txtRenkDuzenleRenkAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RenkDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RenkDuzenle";
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleYesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenkDuzenleKirmizi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRenkDuzenleRenkDuzenle;
        private System.Windows.Forms.TextBox txtRenkDuzenleRenkAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRenkDuzenleYesil;
        private System.Windows.Forms.NumericUpDown nudRenkDuzenleMavi;
        private System.Windows.Forms.NumericUpDown nudRenkDuzenleKirmizi;
    }
}