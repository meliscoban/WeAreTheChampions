
namespace WeAreTheChampions
{
    partial class AnaSayfa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAnaSayfa = new System.Windows.Forms.TabControl();
            this.tabTakimlar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKarsilasmalarTakimlar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKarsilasmalarKarsilasmaSil = new System.Windows.Forms.Button();
            this.btnKarsilasmalarKarsilasmaDuzenle = new System.Windows.Forms.Button();
            this.btnKarsilasmalarKarsilasmaEkle = new System.Windows.Forms.Button();
            this.dgvKarsilasmalarKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.IdKarşılaşma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takım1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takım2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonuç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOyuncular = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOyuncularTakimlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOyuncularOyuncuSil = new System.Windows.Forms.Button();
            this.btnOyuncularOyuncuDuzenle = new System.Windows.Forms.Button();
            this.btnOyuncularOyuncuEkle = new System.Windows.Forms.Button();
            this.dgvOyuncularOyuncular = new System.Windows.Forms.DataGridView();
            this.IdOyuncu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oyuncu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OyuncuTakım = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRenklerTakimlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRenklerRenkSil = new System.Windows.Forms.Button();
            this.btnRenklerRenkDuzenle = new System.Windows.Forms.Button();
            this.btnRenklerRenkEkle = new System.Windows.Forms.Button();
            this.dgvRenklerRenkler = new System.Windows.Forms.DataGridView();
            this.IdRenk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kırmızı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yeşil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mavi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTakimlarTakimDuzenle = new System.Windows.Forms.Button();
            this.btnTakimlarTakimEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTakimlarTakimlar = new System.Windows.Forms.DataGridView();
            this.IdTakım = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takım = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renkler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTakimlarTakimOyunculari = new System.Windows.Forms.Button();
            this.btnTakimlarTakimSil = new System.Windows.Forms.Button();
            this.tabAnaSayfa.SuspendLayout();
            this.tabTakimlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalarKarsilasmalar)).BeginInit();
            this.tabOyuncular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncularOyuncular)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenklerRenkler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlarTakimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAnaSayfa
            // 
            this.tabAnaSayfa.Controls.Add(this.tabTakimlar);
            this.tabAnaSayfa.Controls.Add(this.tabOyuncular);
            this.tabAnaSayfa.Controls.Add(this.tabPage1);
            this.tabAnaSayfa.Controls.Add(this.tabPage2);
            this.tabAnaSayfa.Location = new System.Drawing.Point(13, 14);
            this.tabAnaSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.tabAnaSayfa.Name = "tabAnaSayfa";
            this.tabAnaSayfa.SelectedIndex = 0;
            this.tabAnaSayfa.Size = new System.Drawing.Size(1180, 799);
            this.tabAnaSayfa.TabIndex = 1;
            this.tabAnaSayfa.Tag = "";
            // 
            // tabTakimlar
            // 
            this.tabTakimlar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabTakimlar.Controls.Add(this.label6);
            this.tabTakimlar.Controls.Add(this.cboKarsilasmalarTakimlar);
            this.tabTakimlar.Controls.Add(this.label7);
            this.tabTakimlar.Controls.Add(this.btnKarsilasmalarKarsilasmaSil);
            this.tabTakimlar.Controls.Add(this.btnKarsilasmalarKarsilasmaDuzenle);
            this.tabTakimlar.Controls.Add(this.btnKarsilasmalarKarsilasmaEkle);
            this.tabTakimlar.Controls.Add(this.dgvKarsilasmalarKarsilasmalar);
            this.tabTakimlar.Location = new System.Drawing.Point(4, 28);
            this.tabTakimlar.Margin = new System.Windows.Forms.Padding(4);
            this.tabTakimlar.Name = "tabTakimlar";
            this.tabTakimlar.Padding = new System.Windows.Forms.Padding(4);
            this.tabTakimlar.Size = new System.Drawing.Size(1172, 767);
            this.tabTakimlar.TabIndex = 0;
            this.tabTakimlar.Text = "Karşılaşmalar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Karşılaşmalar";
            // 
            // cboKarsilasmalarTakimlar
            // 
            this.cboKarsilasmalarTakimlar.FormattingEnabled = true;
            this.cboKarsilasmalarTakimlar.Location = new System.Drawing.Point(7, 53);
            this.cboKarsilasmalarTakimlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboKarsilasmalarTakimlar.Name = "cboKarsilasmalarTakimlar";
            this.cboKarsilasmalarTakimlar.Size = new System.Drawing.Size(333, 27);
            this.cboKarsilasmalarTakimlar.TabIndex = 14;
            this.cboKarsilasmalarTakimlar.SelectedIndexChanged += new System.EventHandler(this.cboKarsilasmalarTakimlar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Takımlar";
            // 
            // btnKarsilasmalarKarsilasmaSil
            // 
            this.btnKarsilasmalarKarsilasmaSil.BackColor = System.Drawing.Color.White;
            this.btnKarsilasmalarKarsilasmaSil.Location = new System.Drawing.Point(774, 693);
            this.btnKarsilasmalarKarsilasmaSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnKarsilasmalarKarsilasmaSil.Name = "btnKarsilasmalarKarsilasmaSil";
            this.btnKarsilasmalarKarsilasmaSil.Size = new System.Drawing.Size(214, 51);
            this.btnKarsilasmalarKarsilasmaSil.TabIndex = 3;
            this.btnKarsilasmalarKarsilasmaSil.Text = "Karşılaşmayı Sil";
            this.btnKarsilasmalarKarsilasmaSil.UseVisualStyleBackColor = false;
            this.btnKarsilasmalarKarsilasmaSil.Click += new System.EventHandler(this.btnKarsilasmalarKarsilasmaSil_Click);
            // 
            // btnKarsilasmalarKarsilasmaDuzenle
            // 
            this.btnKarsilasmalarKarsilasmaDuzenle.BackColor = System.Drawing.Color.White;
            this.btnKarsilasmalarKarsilasmaDuzenle.Location = new System.Drawing.Point(178, 693);
            this.btnKarsilasmalarKarsilasmaDuzenle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnKarsilasmalarKarsilasmaDuzenle.Name = "btnKarsilasmalarKarsilasmaDuzenle";
            this.btnKarsilasmalarKarsilasmaDuzenle.Size = new System.Drawing.Size(214, 51);
            this.btnKarsilasmalarKarsilasmaDuzenle.TabIndex = 2;
            this.btnKarsilasmalarKarsilasmaDuzenle.Text = "Karşılaşmayı Düzenle";
            this.btnKarsilasmalarKarsilasmaDuzenle.UseVisualStyleBackColor = false;
            this.btnKarsilasmalarKarsilasmaDuzenle.Click += new System.EventHandler(this.btnKarsilasmalarKarsilasmaDuzenle_Click);
            // 
            // btnKarsilasmalarKarsilasmaEkle
            // 
            this.btnKarsilasmalarKarsilasmaEkle.BackColor = System.Drawing.Color.White;
            this.btnKarsilasmalarKarsilasmaEkle.Location = new System.Drawing.Point(476, 693);
            this.btnKarsilasmalarKarsilasmaEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnKarsilasmalarKarsilasmaEkle.Name = "btnKarsilasmalarKarsilasmaEkle";
            this.btnKarsilasmalarKarsilasmaEkle.Size = new System.Drawing.Size(214, 51);
            this.btnKarsilasmalarKarsilasmaEkle.TabIndex = 1;
            this.btnKarsilasmalarKarsilasmaEkle.Text = "Yeni Karşılaşma Ekle";
            this.btnKarsilasmalarKarsilasmaEkle.UseVisualStyleBackColor = false;
            this.btnKarsilasmalarKarsilasmaEkle.Click += new System.EventHandler(this.btnKarsilasmalarKarsilasmaEkle_Click);
            // 
            // dgvKarsilasmalarKarsilasmalar
            // 
            this.dgvKarsilasmalarKarsilasmalar.AllowUserToAddRows = false;
            this.dgvKarsilasmalarKarsilasmalar.AllowUserToDeleteRows = false;
            this.dgvKarsilasmalarKarsilasmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKarsilasmalarKarsilasmalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKarsilasmalarKarsilasmalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKarsilasmalarKarsilasmalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKarsilasmalarKarsilasmalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKarsilasmalarKarsilasmalar.ColumnHeadersHeight = 35;
            this.dgvKarsilasmalarKarsilasmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKarşılaşma,
            this.Tarih,
            this.Saat,
            this.Takım1,
            this.Takım2,
            this.Skor,
            this.Sonuç});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKarsilasmalarKarsilasmalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKarsilasmalarKarsilasmalar.Location = new System.Drawing.Point(7, 138);
            this.dgvKarsilasmalarKarsilasmalar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvKarsilasmalarKarsilasmalar.MultiSelect = false;
            this.dgvKarsilasmalarKarsilasmalar.Name = "dgvKarsilasmalarKarsilasmalar";
            this.dgvKarsilasmalarKarsilasmalar.ReadOnly = true;
            this.dgvKarsilasmalarKarsilasmalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKarsilasmalarKarsilasmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarsilasmalarKarsilasmalar.Size = new System.Drawing.Size(1153, 529);
            this.dgvKarsilasmalarKarsilasmalar.TabIndex = 0;
            // 
            // IdKarşılaşma
            // 
            this.IdKarşılaşma.DataPropertyName = "Id";
            this.IdKarşılaşma.HeaderText = "Id";
            this.IdKarşılaşma.Name = "IdKarşılaşma";
            this.IdKarşılaşma.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "MatchTimeDateText";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "MatchTimeHourText";
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            // 
            // Takım1
            // 
            this.Takım1.DataPropertyName = "Team1Name";
            this.Takım1.HeaderText = "1.Takım";
            this.Takım1.Name = "Takım1";
            this.Takım1.ReadOnly = true;
            // 
            // Takım2
            // 
            this.Takım2.DataPropertyName = "Team2Name";
            this.Takım2.HeaderText = "2.Takım";
            this.Takım2.Name = "Takım2";
            this.Takım2.ReadOnly = true;
            // 
            // Skor
            // 
            this.Skor.DataPropertyName = "ResultText";
            this.Skor.HeaderText = "Skor";
            this.Skor.Name = "Skor";
            this.Skor.ReadOnly = true;
            // 
            // Sonuç
            // 
            this.Sonuç.DataPropertyName = "Result";
            this.Sonuç.HeaderText = "Sonuç";
            this.Sonuç.Name = "Sonuç";
            this.Sonuç.ReadOnly = true;
            // 
            // tabOyuncular
            // 
            this.tabOyuncular.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabOyuncular.Controls.Add(this.label2);
            this.tabOyuncular.Controls.Add(this.cboOyuncularTakimlar);
            this.tabOyuncular.Controls.Add(this.label1);
            this.tabOyuncular.Controls.Add(this.btnOyuncularOyuncuSil);
            this.tabOyuncular.Controls.Add(this.btnOyuncularOyuncuDuzenle);
            this.tabOyuncular.Controls.Add(this.btnOyuncularOyuncuEkle);
            this.tabOyuncular.Controls.Add(this.dgvOyuncularOyuncular);
            this.tabOyuncular.Location = new System.Drawing.Point(4, 28);
            this.tabOyuncular.Margin = new System.Windows.Forms.Padding(4);
            this.tabOyuncular.Name = "tabOyuncular";
            this.tabOyuncular.Padding = new System.Windows.Forms.Padding(4);
            this.tabOyuncular.Size = new System.Drawing.Size(1166, 767);
            this.tabOyuncular.TabIndex = 2;
            this.tabOyuncular.Text = "Oyuncular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Oyuncular";
            // 
            // cboOyuncularTakimlar
            // 
            this.cboOyuncularTakimlar.FormattingEnabled = true;
            this.cboOyuncularTakimlar.Location = new System.Drawing.Point(7, 53);
            this.cboOyuncularTakimlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboOyuncularTakimlar.Name = "cboOyuncularTakimlar";
            this.cboOyuncularTakimlar.Size = new System.Drawing.Size(333, 27);
            this.cboOyuncularTakimlar.TabIndex = 11;
            this.cboOyuncularTakimlar.SelectedIndexChanged += new System.EventHandler(this.cboOyuncularTakimlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Takımlar";
            // 
            // btnOyuncularOyuncuSil
            // 
            this.btnOyuncularOyuncuSil.BackColor = System.Drawing.Color.White;
            this.btnOyuncularOyuncuSil.Location = new System.Drawing.Point(774, 693);
            this.btnOyuncularOyuncuSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOyuncularOyuncuSil.Name = "btnOyuncularOyuncuSil";
            this.btnOyuncularOyuncuSil.Size = new System.Drawing.Size(214, 51);
            this.btnOyuncularOyuncuSil.TabIndex = 9;
            this.btnOyuncularOyuncuSil.Text = "Oyuncuyu Sil";
            this.btnOyuncularOyuncuSil.UseVisualStyleBackColor = false;
            this.btnOyuncularOyuncuSil.Click += new System.EventHandler(this.btnOyuncularOyuncuSil_Click);
            // 
            // btnOyuncularOyuncuDuzenle
            // 
            this.btnOyuncularOyuncuDuzenle.BackColor = System.Drawing.Color.White;
            this.btnOyuncularOyuncuDuzenle.Location = new System.Drawing.Point(178, 693);
            this.btnOyuncularOyuncuDuzenle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOyuncularOyuncuDuzenle.Name = "btnOyuncularOyuncuDuzenle";
            this.btnOyuncularOyuncuDuzenle.Size = new System.Drawing.Size(214, 51);
            this.btnOyuncularOyuncuDuzenle.TabIndex = 8;
            this.btnOyuncularOyuncuDuzenle.Text = "Oyuncuyu Düzenle";
            this.btnOyuncularOyuncuDuzenle.UseVisualStyleBackColor = false;
            this.btnOyuncularOyuncuDuzenle.Click += new System.EventHandler(this.btnOyuncularOyuncuDuzenle_Click);
            // 
            // btnOyuncularOyuncuEkle
            // 
            this.btnOyuncularOyuncuEkle.BackColor = System.Drawing.Color.White;
            this.btnOyuncularOyuncuEkle.Location = new System.Drawing.Point(476, 693);
            this.btnOyuncularOyuncuEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOyuncularOyuncuEkle.Name = "btnOyuncularOyuncuEkle";
            this.btnOyuncularOyuncuEkle.Size = new System.Drawing.Size(214, 51);
            this.btnOyuncularOyuncuEkle.TabIndex = 7;
            this.btnOyuncularOyuncuEkle.Text = "Yeni Oyuncu Ekle";
            this.btnOyuncularOyuncuEkle.UseVisualStyleBackColor = false;
            this.btnOyuncularOyuncuEkle.Click += new System.EventHandler(this.btnOyuncularOyuncuEkle_Click);
            // 
            // dgvOyuncularOyuncular
            // 
            this.dgvOyuncularOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncularOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncularOyuncular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOyuncularOyuncular.BackgroundColor = System.Drawing.Color.White;
            this.dgvOyuncularOyuncular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOyuncularOyuncular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOyuncularOyuncular.ColumnHeadersHeight = 35;
            this.dgvOyuncularOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOyuncu,
            this.Oyuncu,
            this.OyuncuTakım});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOyuncularOyuncular.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOyuncularOyuncular.Location = new System.Drawing.Point(7, 138);
            this.dgvOyuncularOyuncular.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvOyuncularOyuncular.MultiSelect = false;
            this.dgvOyuncularOyuncular.Name = "dgvOyuncularOyuncular";
            this.dgvOyuncularOyuncular.ReadOnly = true;
            this.dgvOyuncularOyuncular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOyuncularOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncularOyuncular.Size = new System.Drawing.Size(1153, 529);
            this.dgvOyuncularOyuncular.TabIndex = 0;
            // 
            // IdOyuncu
            // 
            this.IdOyuncu.DataPropertyName = "Id";
            this.IdOyuncu.HeaderText = "Id";
            this.IdOyuncu.Name = "IdOyuncu";
            this.IdOyuncu.ReadOnly = true;
            // 
            // Oyuncu
            // 
            this.Oyuncu.DataPropertyName = "PlayerName";
            this.Oyuncu.HeaderText = "Oyuncu";
            this.Oyuncu.Name = "Oyuncu";
            this.Oyuncu.ReadOnly = true;
            // 
            // OyuncuTakım
            // 
            this.OyuncuTakım.DataPropertyName = "TeamName";
            this.OyuncuTakım.HeaderText = "Takım";
            this.OyuncuTakım.Name = "OyuncuTakım";
            this.OyuncuTakım.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboRenklerTakimlar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnRenklerRenkSil);
            this.tabPage1.Controls.Add(this.btnRenklerRenkDuzenle);
            this.tabPage1.Controls.Add(this.btnRenklerRenkEkle);
            this.tabPage1.Controls.Add(this.dgvRenklerRenkler);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(1172, 767);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Renkler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Renkler";
            // 
            // cboRenklerTakimlar
            // 
            this.cboRenklerTakimlar.FormattingEnabled = true;
            this.cboRenklerTakimlar.Location = new System.Drawing.Point(7, 53);
            this.cboRenklerTakimlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cboRenklerTakimlar.Name = "cboRenklerTakimlar";
            this.cboRenklerTakimlar.Size = new System.Drawing.Size(333, 27);
            this.cboRenklerTakimlar.TabIndex = 18;
            this.cboRenklerTakimlar.SelectedIndexChanged += new System.EventHandler(this.cboRenklerTakimlar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Takımlar";
            // 
            // btnRenklerRenkSil
            // 
            this.btnRenklerRenkSil.BackColor = System.Drawing.Color.White;
            this.btnRenklerRenkSil.Location = new System.Drawing.Point(774, 693);
            this.btnRenklerRenkSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRenklerRenkSil.Name = "btnRenklerRenkSil";
            this.btnRenklerRenkSil.Size = new System.Drawing.Size(214, 51);
            this.btnRenklerRenkSil.TabIndex = 16;
            this.btnRenklerRenkSil.Text = "Rengi Sil";
            this.btnRenklerRenkSil.UseVisualStyleBackColor = false;
            this.btnRenklerRenkSil.Click += new System.EventHandler(this.btnRenklerRenkSil_Click);
            // 
            // btnRenklerRenkDuzenle
            // 
            this.btnRenklerRenkDuzenle.BackColor = System.Drawing.Color.White;
            this.btnRenklerRenkDuzenle.Location = new System.Drawing.Point(178, 693);
            this.btnRenklerRenkDuzenle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRenklerRenkDuzenle.Name = "btnRenklerRenkDuzenle";
            this.btnRenklerRenkDuzenle.Size = new System.Drawing.Size(214, 51);
            this.btnRenklerRenkDuzenle.TabIndex = 15;
            this.btnRenklerRenkDuzenle.Text = "Rengi Düzenle";
            this.btnRenklerRenkDuzenle.UseVisualStyleBackColor = false;
            this.btnRenklerRenkDuzenle.Click += new System.EventHandler(this.btnRenklerRenkDuzenle_Click);
            // 
            // btnRenklerRenkEkle
            // 
            this.btnRenklerRenkEkle.BackColor = System.Drawing.Color.White;
            this.btnRenklerRenkEkle.Location = new System.Drawing.Point(476, 693);
            this.btnRenklerRenkEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRenklerRenkEkle.Name = "btnRenklerRenkEkle";
            this.btnRenklerRenkEkle.Size = new System.Drawing.Size(214, 51);
            this.btnRenklerRenkEkle.TabIndex = 14;
            this.btnRenklerRenkEkle.Text = "Yeni Renk Ekle";
            this.btnRenklerRenkEkle.UseVisualStyleBackColor = false;
            this.btnRenklerRenkEkle.Click += new System.EventHandler(this.btnRenklerRenkEkle_Click);
            // 
            // dgvRenklerRenkler
            // 
            this.dgvRenklerRenkler.AllowUserToAddRows = false;
            this.dgvRenklerRenkler.AllowUserToDeleteRows = false;
            this.dgvRenklerRenkler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRenklerRenkler.BackgroundColor = System.Drawing.Color.White;
            this.dgvRenklerRenkler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRenklerRenkler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRenklerRenkler.ColumnHeadersHeight = 35;
            this.dgvRenklerRenkler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRenk,
            this.Renk,
            this.Kırmızı,
            this.Yeşil,
            this.Mavi});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRenklerRenkler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRenklerRenkler.Location = new System.Drawing.Point(7, 138);
            this.dgvRenklerRenkler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvRenklerRenkler.MultiSelect = false;
            this.dgvRenklerRenkler.Name = "dgvRenklerRenkler";
            this.dgvRenklerRenkler.ReadOnly = true;
            this.dgvRenklerRenkler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRenklerRenkler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenklerRenkler.Size = new System.Drawing.Size(1155, 529);
            this.dgvRenklerRenkler.TabIndex = 13;
            // 
            // IdRenk
            // 
            this.IdRenk.DataPropertyName = "Id";
            this.IdRenk.HeaderText = "Id";
            this.IdRenk.Name = "IdRenk";
            this.IdRenk.ReadOnly = true;
            // 
            // Renk
            // 
            this.Renk.DataPropertyName = "ColorName";
            this.Renk.HeaderText = "Renk";
            this.Renk.Name = "Renk";
            this.Renk.ReadOnly = true;
            // 
            // Kırmızı
            // 
            this.Kırmızı.DataPropertyName = "Red";
            this.Kırmızı.HeaderText = "Kırmızı";
            this.Kırmızı.Name = "Kırmızı";
            this.Kırmızı.ReadOnly = true;
            // 
            // Yeşil
            // 
            this.Yeşil.DataPropertyName = "Green";
            this.Yeşil.HeaderText = "Yeşil";
            this.Yeşil.Name = "Yeşil";
            this.Yeşil.ReadOnly = true;
            // 
            // Mavi
            // 
            this.Mavi.DataPropertyName = "Blue";
            this.Mavi.HeaderText = "Mavi";
            this.Mavi.Name = "Mavi";
            this.Mavi.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.Controls.Add(this.btnTakimlarTakimDuzenle);
            this.tabPage2.Controls.Add(this.btnTakimlarTakimEkle);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvTakimlarTakimlar);
            this.tabPage2.Controls.Add(this.btnTakimlarTakimOyunculari);
            this.tabPage2.Controls.Add(this.btnTakimlarTakimSil);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1166, 767);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Takımlar";
            // 
            // btnTakimlarTakimDuzenle
            // 
            this.btnTakimlarTakimDuzenle.BackColor = System.Drawing.Color.White;
            this.btnTakimlarTakimDuzenle.Location = new System.Drawing.Point(30, 693);
            this.btnTakimlarTakimDuzenle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTakimlarTakimDuzenle.Name = "btnTakimlarTakimDuzenle";
            this.btnTakimlarTakimDuzenle.Size = new System.Drawing.Size(214, 51);
            this.btnTakimlarTakimDuzenle.TabIndex = 19;
            this.btnTakimlarTakimDuzenle.Text = "Takımı Düzenle";
            this.btnTakimlarTakimDuzenle.UseVisualStyleBackColor = false;
            this.btnTakimlarTakimDuzenle.Click += new System.EventHandler(this.btnTakimlarTakimDuzenle_Click);
            // 
            // btnTakimlarTakimEkle
            // 
            this.btnTakimlarTakimEkle.BackColor = System.Drawing.Color.White;
            this.btnTakimlarTakimEkle.Location = new System.Drawing.Point(328, 693);
            this.btnTakimlarTakimEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTakimlarTakimEkle.Name = "btnTakimlarTakimEkle";
            this.btnTakimlarTakimEkle.Size = new System.Drawing.Size(214, 51);
            this.btnTakimlarTakimEkle.TabIndex = 18;
            this.btnTakimlarTakimEkle.Text = "Yeni Takım Ekle";
            this.btnTakimlarTakimEkle.UseVisualStyleBackColor = false;
            this.btnTakimlarTakimEkle.Click += new System.EventHandler(this.btnTakimlarTakimEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Takımlar";
            // 
            // dgvTakimlarTakimlar
            // 
            this.dgvTakimlarTakimlar.AllowUserToAddRows = false;
            this.dgvTakimlarTakimlar.AllowUserToDeleteRows = false;
            this.dgvTakimlarTakimlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakimlarTakimlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvTakimlarTakimlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTakimlarTakimlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTakimlarTakimlar.ColumnHeadersHeight = 35;
            this.dgvTakimlarTakimlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTakım,
            this.Takım,
            this.Renkler});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTakimlarTakimlar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTakimlarTakimlar.Location = new System.Drawing.Point(7, 51);
            this.dgvTakimlarTakimlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvTakimlarTakimlar.MultiSelect = false;
            this.dgvTakimlarTakimlar.Name = "dgvTakimlarTakimlar";
            this.dgvTakimlarTakimlar.ReadOnly = true;
            this.dgvTakimlarTakimlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTakimlarTakimlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakimlarTakimlar.Size = new System.Drawing.Size(1148, 616);
            this.dgvTakimlarTakimlar.TabIndex = 16;
            // 
            // IdTakım
            // 
            this.IdTakım.DataPropertyName = "Id";
            this.IdTakım.HeaderText = "Id";
            this.IdTakım.Name = "IdTakım";
            this.IdTakım.ReadOnly = true;
            // 
            // Takım
            // 
            this.Takım.DataPropertyName = "TeamName";
            this.Takım.HeaderText = "Takım";
            this.Takım.Name = "Takım";
            this.Takım.ReadOnly = true;
            // 
            // Renkler
            // 
            this.Renkler.HeaderText = "Renkler";
            this.Renkler.Name = "Renkler";
            this.Renkler.ReadOnly = true;
            // 
            // btnTakimlarTakimOyunculari
            // 
            this.btnTakimlarTakimOyunculari.BackColor = System.Drawing.Color.White;
            this.btnTakimlarTakimOyunculari.Location = new System.Drawing.Point(923, 693);
            this.btnTakimlarTakimOyunculari.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTakimlarTakimOyunculari.Name = "btnTakimlarTakimOyunculari";
            this.btnTakimlarTakimOyunculari.Size = new System.Drawing.Size(214, 51);
            this.btnTakimlarTakimOyunculari.TabIndex = 15;
            this.btnTakimlarTakimOyunculari.Text = "Takım Oyuncuları";
            this.btnTakimlarTakimOyunculari.UseVisualStyleBackColor = false;
            this.btnTakimlarTakimOyunculari.Click += new System.EventHandler(this.btnTakimlarTakimOyunculari_Click);
            // 
            // btnTakimlarTakimSil
            // 
            this.btnTakimlarTakimSil.BackColor = System.Drawing.Color.White;
            this.btnTakimlarTakimSil.Location = new System.Drawing.Point(625, 693);
            this.btnTakimlarTakimSil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTakimlarTakimSil.Name = "btnTakimlarTakimSil";
            this.btnTakimlarTakimSil.Size = new System.Drawing.Size(214, 51);
            this.btnTakimlarTakimSil.TabIndex = 14;
            this.btnTakimlarTakimSil.Text = "Takımı Sil";
            this.btnTakimlarTakimSil.UseVisualStyleBackColor = false;
            this.btnTakimlarTakimSil.Click += new System.EventHandler(this.btnTakimlarTakimSil_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 826);
            this.Controls.Add(this.tabAnaSayfa);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabAnaSayfa.ResumeLayout(false);
            this.tabTakimlar.ResumeLayout(false);
            this.tabTakimlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalarKarsilasmalar)).EndInit();
            this.tabOyuncular.ResumeLayout(false);
            this.tabOyuncular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncularOyuncular)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenklerRenkler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlarTakimlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAnaSayfa;
        private System.Windows.Forms.TabPage tabTakimlar;
        private System.Windows.Forms.Button btnKarsilasmalarKarsilasmaEkle;
        private System.Windows.Forms.DataGridView dgvKarsilasmalarKarsilasmalar;
        private System.Windows.Forms.TabPage tabOyuncular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnKarsilasmalarKarsilasmaSil;
        private System.Windows.Forms.Button btnKarsilasmalarKarsilasmaDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOyuncularTakimlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOyuncularOyuncuSil;
        private System.Windows.Forms.Button btnOyuncularOyuncuDuzenle;
        private System.Windows.Forms.Button btnOyuncularOyuncuEkle;
        private System.Windows.Forms.DataGridView dgvOyuncularOyuncular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRenklerTakimlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRenklerRenkSil;
        private System.Windows.Forms.Button btnRenklerRenkDuzenle;
        private System.Windows.Forms.Button btnRenklerRenkEkle;
        private System.Windows.Forms.DataGridView dgvRenklerRenkler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboKarsilasmalarTakimlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTakimlarTakimlar;
        private System.Windows.Forms.Button btnTakimlarTakimOyunculari;
        private System.Windows.Forms.Button btnTakimlarTakimSil;
        private System.Windows.Forms.Button btnTakimlarTakimDuzenle;
        private System.Windows.Forms.Button btnTakimlarTakimEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRenk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kırmızı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yeşil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mavi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTakım;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takım;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renkler;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOyuncu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oyuncu;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuTakım;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKarşılaşma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takım1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takım2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuç;
    }
}

