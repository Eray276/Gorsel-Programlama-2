﻿namespace WindowsFormsApp3
{
    partial class MüsteriForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriForm));
            this.Film_btn = new System.Windows.Forms.Button();
            this.Tarih_btn = new System.Windows.Forms.Button();
            this.Seans_btn = new System.Windows.Forms.Button();
            this.Salon_btn = new System.Windows.Forms.Button();
            this.Müsteri_btn = new System.Windows.Forms.Button();
            this.A1_btn = new System.Windows.Forms.Button();
            this.A2_btn = new System.Windows.Forms.Button();
            this.A3_btn = new System.Windows.Forms.Button();
            this.A4_btn = new System.Windows.Forms.Button();
            this.A5_btn = new System.Windows.Forms.Button();
            this.B1_btn = new System.Windows.Forms.Button();
            this.B2_btn = new System.Windows.Forms.Button();
            this.B3_btn = new System.Windows.Forms.Button();
            this.B4_btn = new System.Windows.Forms.Button();
            this.B5_btn = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.dataGridMüsteri = new System.Windows.Forms.DataGridView();
            this.Güncelle_btn = new System.Windows.Forms.Button();
            this.Yenile_btn = new System.Windows.Forms.Button();
            this.Sil_btn = new System.Windows.Forms.Button();
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.Film_cmb = new System.Windows.Forms.ComboBox();
            this.BiletAralıgı_txt = new System.Windows.Forms.TextBox();
            this.BiletSys_txt = new System.Windows.Forms.TextBox();
            this.AdSoyad_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salon_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrintBTN = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMüsteri)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Film_btn
            // 
            this.Film_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Film_btn.Location = new System.Drawing.Point(12, 12);
            this.Film_btn.Name = "Film_btn";
            this.Film_btn.Size = new System.Drawing.Size(125, 44);
            this.Film_btn.TabIndex = 0;
            this.Film_btn.Text = "Film";
            this.Film_btn.UseVisualStyleBackColor = true;
            this.Film_btn.Click += new System.EventHandler(this.Film_btn_Click);
            // 
            // Tarih_btn
            // 
            this.Tarih_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih_btn.Location = new System.Drawing.Point(143, 12);
            this.Tarih_btn.Name = "Tarih_btn";
            this.Tarih_btn.Size = new System.Drawing.Size(137, 44);
            this.Tarih_btn.TabIndex = 1;
            this.Tarih_btn.Text = "Tarih";
            this.Tarih_btn.UseVisualStyleBackColor = true;
            // 
            // Seans_btn
            // 
            this.Seans_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Seans_btn.Location = new System.Drawing.Point(286, 12);
            this.Seans_btn.Name = "Seans_btn";
            this.Seans_btn.Size = new System.Drawing.Size(125, 44);
            this.Seans_btn.TabIndex = 2;
            this.Seans_btn.Text = "Seans";
            this.Seans_btn.UseVisualStyleBackColor = true;
            // 
            // Salon_btn
            // 
            this.Salon_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Salon_btn.Location = new System.Drawing.Point(12, 62);
            this.Salon_btn.Name = "Salon_btn";
            this.Salon_btn.Size = new System.Drawing.Size(399, 44);
            this.Salon_btn.TabIndex = 3;
            this.Salon_btn.Text = "Salon";
            this.Salon_btn.UseVisualStyleBackColor = true;
            this.Salon_btn.Click += new System.EventHandler(this.Salon_btn_Click);
            // 
            // Müsteri_btn
            // 
            this.Müsteri_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Müsteri_btn.Location = new System.Drawing.Point(417, 12);
            this.Müsteri_btn.Name = "Müsteri_btn";
            this.Müsteri_btn.Size = new System.Drawing.Size(651, 44);
            this.Müsteri_btn.TabIndex = 4;
            this.Müsteri_btn.Text = "Müsteri";
            this.Müsteri_btn.UseVisualStyleBackColor = true;
            // 
            // A1_btn
            // 
            this.A1_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A1_btn.Location = new System.Drawing.Point(0, -4);
            this.A1_btn.Name = "A1_btn";
            this.A1_btn.Size = new System.Drawing.Size(75, 44);
            this.A1_btn.TabIndex = 5;
            this.A1_btn.Text = "A1";
            this.A1_btn.UseVisualStyleBackColor = true;
            this.A1_btn.Click += new System.EventHandler(this.A1_btn_Click);
            // 
            // A2_btn
            // 
            this.A2_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A2_btn.Location = new System.Drawing.Point(81, -4);
            this.A2_btn.Name = "A2_btn";
            this.A2_btn.Size = new System.Drawing.Size(75, 44);
            this.A2_btn.TabIndex = 6;
            this.A2_btn.Text = "A2";
            this.A2_btn.UseVisualStyleBackColor = true;
            // 
            // A3_btn
            // 
            this.A3_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A3_btn.Location = new System.Drawing.Point(162, -4);
            this.A3_btn.Name = "A3_btn";
            this.A3_btn.Size = new System.Drawing.Size(75, 44);
            this.A3_btn.TabIndex = 7;
            this.A3_btn.Text = "A3";
            this.A3_btn.UseVisualStyleBackColor = true;
            // 
            // A4_btn
            // 
            this.A4_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A4_btn.Location = new System.Drawing.Point(243, -4);
            this.A4_btn.Name = "A4_btn";
            this.A4_btn.Size = new System.Drawing.Size(75, 44);
            this.A4_btn.TabIndex = 8;
            this.A4_btn.Text = "A4";
            this.A4_btn.UseVisualStyleBackColor = true;
            // 
            // A5_btn
            // 
            this.A5_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A5_btn.Location = new System.Drawing.Point(324, -4);
            this.A5_btn.Name = "A5_btn";
            this.A5_btn.Size = new System.Drawing.Size(75, 44);
            this.A5_btn.TabIndex = 9;
            this.A5_btn.Text = "A5";
            this.A5_btn.UseVisualStyleBackColor = true;
            // 
            // B1_btn
            // 
            this.B1_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B1_btn.Location = new System.Drawing.Point(0, 46);
            this.B1_btn.Name = "B1_btn";
            this.B1_btn.Size = new System.Drawing.Size(75, 44);
            this.B1_btn.TabIndex = 10;
            this.B1_btn.Text = "B1";
            this.B1_btn.UseVisualStyleBackColor = true;
            // 
            // B2_btn
            // 
            this.B2_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B2_btn.Location = new System.Drawing.Point(81, 46);
            this.B2_btn.Name = "B2_btn";
            this.B2_btn.Size = new System.Drawing.Size(75, 44);
            this.B2_btn.TabIndex = 11;
            this.B2_btn.Text = "B2";
            this.B2_btn.UseVisualStyleBackColor = true;
            // 
            // B3_btn
            // 
            this.B3_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B3_btn.Location = new System.Drawing.Point(162, 46);
            this.B3_btn.Name = "B3_btn";
            this.B3_btn.Size = new System.Drawing.Size(75, 44);
            this.B3_btn.TabIndex = 12;
            this.B3_btn.Text = "B3";
            this.B3_btn.UseVisualStyleBackColor = true;
            // 
            // B4_btn
            // 
            this.B4_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B4_btn.Location = new System.Drawing.Point(243, 46);
            this.B4_btn.Name = "B4_btn";
            this.B4_btn.Size = new System.Drawing.Size(75, 44);
            this.B4_btn.TabIndex = 13;
            this.B4_btn.Text = "B4";
            this.B4_btn.UseVisualStyleBackColor = true;
            // 
            // B5_btn
            // 
            this.B5_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B5_btn.Location = new System.Drawing.Point(324, 46);
            this.B5_btn.Name = "B5_btn";
            this.B5_btn.Size = new System.Drawing.Size(75, 44);
            this.B5_btn.TabIndex = 14;
            this.B5_btn.Text = "B5";
            this.B5_btn.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(0, 96);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 44);
            this.button16.TabIndex = 15;
            this.button16.Text = "C1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(81, 96);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 44);
            this.button17.TabIndex = 16;
            this.button17.Text = "C2";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(162, 96);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 44);
            this.button18.TabIndex = 17;
            this.button18.Text = "C3";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(243, 96);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 44);
            this.button19.TabIndex = 18;
            this.button19.Text = "C4";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(324, 96);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 44);
            this.button20.TabIndex = 19;
            this.button20.Text = "C5";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(0, 146);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 44);
            this.button21.TabIndex = 20;
            this.button21.Text = "D1";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(81, 146);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 44);
            this.button22.TabIndex = 21;
            this.button22.Text = "D2";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(162, 146);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 44);
            this.button23.TabIndex = 22;
            this.button23.Text = "D3";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.Location = new System.Drawing.Point(243, 146);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 44);
            this.button24.TabIndex = 23;
            this.button24.Text = "D4";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.Location = new System.Drawing.Point(324, 146);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 44);
            this.button25.TabIndex = 24;
            this.button25.Text = "D5";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(0, 196);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 44);
            this.button26.TabIndex = 25;
            this.button26.Text = "E1";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.Location = new System.Drawing.Point(81, 196);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 44);
            this.button27.TabIndex = 26;
            this.button27.Text = "E2";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.Location = new System.Drawing.Point(162, 196);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 44);
            this.button28.TabIndex = 27;
            this.button28.Text = "E3";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.Location = new System.Drawing.Point(243, 196);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 44);
            this.button29.TabIndex = 28;
            this.button29.Text = "E4";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.Location = new System.Drawing.Point(324, 196);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 44);
            this.button30.TabIndex = 29;
            this.button30.Text = "E5";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // dataGridMüsteri
            // 
            this.dataGridMüsteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMüsteri.Location = new System.Drawing.Point(417, 62);
            this.dataGridMüsteri.Name = "dataGridMüsteri";
            this.dataGridMüsteri.Size = new System.Drawing.Size(651, 294);
            this.dataGridMüsteri.TabIndex = 30;
            this.dataGridMüsteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMüsteri_CellDoubleClick);
            // 
            // Güncelle_btn
            // 
            this.Güncelle_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle_btn.Location = new System.Drawing.Point(1227, 242);
            this.Güncelle_btn.Name = "Güncelle_btn";
            this.Güncelle_btn.Size = new System.Drawing.Size(186, 55);
            this.Güncelle_btn.TabIndex = 43;
            this.Güncelle_btn.Text = "Müşteri Güncelle";
            this.Güncelle_btn.UseVisualStyleBackColor = true;
            this.Güncelle_btn.Click += new System.EventHandler(this.Güncelle_btn_Click);
            // 
            // Yenile_btn
            // 
            this.Yenile_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile_btn.Location = new System.Drawing.Point(1227, 303);
            this.Yenile_btn.Name = "Yenile_btn";
            this.Yenile_btn.Size = new System.Drawing.Size(185, 53);
            this.Yenile_btn.TabIndex = 42;
            this.Yenile_btn.Text = "Yenile";
            this.Yenile_btn.UseVisualStyleBackColor = true;
            this.Yenile_btn.Click += new System.EventHandler(this.Yenile_btn_Click);
            // 
            // Sil_btn
            // 
            this.Sil_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_btn.Location = new System.Drawing.Point(1076, 303);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(144, 53);
            this.Sil_btn.TabIndex = 41;
            this.Sil_btn.Text = "Müşteri Sil";
            this.Sil_btn.UseVisualStyleBackColor = true;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_btn.Location = new System.Drawing.Point(1076, 242);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(144, 55);
            this.Ekle_btn.TabIndex = 40;
            this.Ekle_btn.Text = "Müşteri Ekle";
            this.Ekle_btn.UseVisualStyleBackColor = true;
            this.Ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // Film_cmb
            // 
            this.Film_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Film_cmb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Film_cmb.FormattingEnabled = true;
            this.Film_cmb.Location = new System.Drawing.Point(1227, 152);
            this.Film_cmb.Name = "Film_cmb";
            this.Film_cmb.Size = new System.Drawing.Size(185, 39);
            this.Film_cmb.TabIndex = 51;
            // 
            // BiletAralıgı_txt
            // 
            this.BiletAralıgı_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletAralıgı_txt.Location = new System.Drawing.Point(1227, 107);
            this.BiletAralıgı_txt.Name = "BiletAralıgı_txt";
            this.BiletAralıgı_txt.Size = new System.Drawing.Size(185, 39);
            this.BiletAralıgı_txt.TabIndex = 50;
            // 
            // BiletSys_txt
            // 
            this.BiletSys_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletSys_txt.Location = new System.Drawing.Point(1227, 62);
            this.BiletSys_txt.Name = "BiletSys_txt";
            this.BiletSys_txt.Size = new System.Drawing.Size(185, 39);
            this.BiletSys_txt.TabIndex = 49;
            // 
            // AdSoyad_txt
            // 
            this.AdSoyad_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyad_txt.Location = new System.Drawing.Point(1227, 17);
            this.AdSoyad_txt.Name = "AdSoyad_txt";
            this.AdSoyad_txt.Size = new System.Drawing.Size(185, 39);
            this.AdSoyad_txt.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1074, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1074, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Bilet Aralığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1074, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Bilet Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1074, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ad Soyad";
            // 
            // Salon_cmb
            // 
            this.Salon_cmb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Salon_cmb.FormattingEnabled = true;
            this.Salon_cmb.Location = new System.Drawing.Point(1227, 197);
            this.Salon_cmb.Name = "Salon_cmb";
            this.Salon_cmb.Size = new System.Drawing.Size(185, 39);
            this.Salon_cmb.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1074, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 53;
            this.label5.Text = "Salon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(915, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "label6";
            // 
            // PrintBTN
            // 
            this.PrintBTN.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrintBTN.Location = new System.Drawing.Point(124, 362);
            this.PrintBTN.Name = "PrintBTN";
            this.PrintBTN.Size = new System.Drawing.Size(187, 44);
            this.PrintBTN.TabIndex = 55;
            this.PrintBTN.Text = "Müşteri Print";
            this.PrintBTN.UseVisualStyleBackColor = true;
            this.PrintBTN.Click += new System.EventHandler(this.PrintBTN_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(663, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 44);
            this.button1.TabIndex = 56;
            this.button1.Text = "Koltuk Print";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.A2_btn);
            this.panel1.Controls.Add(this.A1_btn);
            this.panel1.Controls.Add(this.A3_btn);
            this.panel1.Controls.Add(this.A4_btn);
            this.panel1.Controls.Add(this.A5_btn);
            this.panel1.Controls.Add(this.B1_btn);
            this.panel1.Controls.Add(this.B2_btn);
            this.panel1.Controls.Add(this.B3_btn);
            this.panel1.Controls.Add(this.B4_btn);
            this.panel1.Controls.Add(this.B5_btn);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button30);
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button28);
            this.panel1.Controls.Add(this.button27);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 249);
            this.panel1.TabIndex = 57;
            // 
            // MüsteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1420, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrintBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salon_cmb);
            this.Controls.Add(this.Film_cmb);
            this.Controls.Add(this.BiletAralıgı_txt);
            this.Controls.Add(this.BiletSys_txt);
            this.Controls.Add(this.AdSoyad_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Güncelle_btn);
            this.Controls.Add(this.Yenile_btn);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.Ekle_btn);
            this.Controls.Add(this.dataGridMüsteri);
            this.Controls.Add(this.Müsteri_btn);
            this.Controls.Add(this.Salon_btn);
            this.Controls.Add(this.Seans_btn);
            this.Controls.Add(this.Tarih_btn);
            this.Controls.Add(this.Film_btn);
            this.Name = "MüsteriForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMüsteri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Film_btn;
        private System.Windows.Forms.Button Tarih_btn;
        private System.Windows.Forms.Button Seans_btn;
        private System.Windows.Forms.Button Salon_btn;
        private System.Windows.Forms.Button Müsteri_btn;
        private System.Windows.Forms.Button A1_btn;
        private System.Windows.Forms.Button A2_btn;
        private System.Windows.Forms.Button A3_btn;
        private System.Windows.Forms.Button A4_btn;
        private System.Windows.Forms.Button A5_btn;
        private System.Windows.Forms.Button B1_btn;
        private System.Windows.Forms.Button B2_btn;
        private System.Windows.Forms.Button B3_btn;
        private System.Windows.Forms.Button B4_btn;
        private System.Windows.Forms.Button B5_btn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.DataGridView dataGridMüsteri;
        private System.Windows.Forms.Button Güncelle_btn;
        private System.Windows.Forms.Button Yenile_btn;
        private System.Windows.Forms.Button Sil_btn;
        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.ComboBox Film_cmb;
        private System.Windows.Forms.TextBox BiletAralıgı_txt;
        private System.Windows.Forms.TextBox BiletSys_txt;
        private System.Windows.Forms.TextBox AdSoyad_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Salon_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PrintBTN;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

