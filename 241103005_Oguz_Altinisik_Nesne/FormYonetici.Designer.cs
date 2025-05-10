namespace _241103005_Oguz_Altinisik_Nesne
{
    partial class FormYonetici
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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adlabel = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnYetkiGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.txtsifre2 = new System.Windows.Forms.TextBox();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(522, 238);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(180, 131);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "EKLE";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETİCİ PANELİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre Girin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email Girin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyad Girin:";
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Location = new System.Drawing.Point(101, 143);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(57, 16);
            this.adlabel.TabIndex = 14;
            this.adlabel.Text = "Ad Girin:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(193, 279);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(193, 189);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(193, 137);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rol Seçin:";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(193, 323);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 24);
            this.cmbRol.TabIndex = 19;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(750, 238);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(180, 131);
            this.btnKullaniciSil.TabIndex = 20;
            this.btnKullaniciSil.Text = "SİL";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnYetkiGuncelle
            // 
            this.btnYetkiGuncelle.Location = new System.Drawing.Point(978, 238);
            this.btnYetkiGuncelle.Name = "btnYetkiGuncelle";
            this.btnYetkiGuncelle.Size = new System.Drawing.Size(180, 131);
            this.btnYetkiGuncelle.TabIndex = 21;
            this.btnYetkiGuncelle.Text = "YETKİ GÜNCELLE";
            this.btnYetkiGuncelle.UseVisualStyleBackColor = true;
            this.btnYetkiGuncelle.Click += new System.EventHandler(this.btnYetkiGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email Girin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Şifre Girin:";
            // 
            // txtemail2
            // 
            this.txtemail2.Location = new System.Drawing.Point(535, 436);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(100, 22);
            this.txtemail2.TabIndex = 24;
            // 
            // txtsifre2
            // 
            this.txtsifre2.Location = new System.Drawing.Point(535, 482);
            this.txtsifre2.Name = "txtsifre2";
            this.txtsifre2.Size = new System.Drawing.Size(100, 22);
            this.txtsifre2.TabIndex = 25;
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Location = new System.Drawing.Point(709, 398);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(180, 131);
            this.btnSifreGuncelle.TabIndex = 26;
            this.btnSifreGuncelle.Text = "ŞİFRE GÜNCELLE";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 131);
            this.button1.TabIndex = 27;
            this.button1.Text = "VERİTABANI YEDEKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVeritabaniYedekle_Click);
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(814, 23);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.RowHeadersWidth = 51;
            this.dataGridViewKullanicilar.RowTemplate.Height = 24;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(300, 199);
            this.dataGridViewKullanicilar.TabIndex = 30;
            this.dataGridViewKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1209, 238);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(180, 131);
            this.btnListele.TabIndex = 31;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(1150, 398);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(180, 131);
            this.btnAnaSayfa.TabIndex = 32;
            this.btnAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 657);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSifreGuncelle);
            this.Controls.Add(this.txtsifre2);
            this.Controls.Add(this.txtemail2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnYetkiGuncelle);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adlabel);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Name = "FormYonetici";
            this.Text = "FormYonetici";
            this.Load += new System.EventHandler(this.FormYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnYetkiGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.TextBox txtsifre2;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}