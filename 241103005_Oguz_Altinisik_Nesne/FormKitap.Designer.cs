namespace _241103005_Oguz_Altinisik_Nesne
{
    partial class FormKitap
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
            this.lblkitapadi = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.lblsayfa = new System.Windows.Forms.Label();
            this.lblbasimyili = new System.Windows.Forms.Label();
            this.lblkategori = new System.Windows.Forms.Label();
            this.lblyayinevi = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxYayinevi = new System.Windows.Forms.ComboBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkitapadi
            // 
            this.lblkitapadi.AutoSize = true;
            this.lblkitapadi.Location = new System.Drawing.Point(121, 61);
            this.lblkitapadi.Name = "lblkitapadi";
            this.lblkitapadi.Size = new System.Drawing.Size(63, 16);
            this.lblkitapadi.TabIndex = 0;
            this.lblkitapadi.Text = "Kitap Adı:";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(121, 112);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(41, 16);
            this.lblisbn.TabIndex = 1;
            this.lblisbn.Text = "ISBN:";
            // 
            // lblsayfa
            // 
            this.lblsayfa.AutoSize = true;
            this.lblsayfa.Location = new System.Drawing.Point(121, 154);
            this.lblsayfa.Name = "lblsayfa";
            this.lblsayfa.Size = new System.Drawing.Size(85, 16);
            this.lblsayfa.TabIndex = 2;
            this.lblsayfa.Text = "Sayfa Sayısı:";
            // 
            // lblbasimyili
            // 
            this.lblbasimyili.AutoSize = true;
            this.lblbasimyili.Location = new System.Drawing.Point(121, 194);
            this.lblbasimyili.Name = "lblbasimyili";
            this.lblbasimyili.Size = new System.Drawing.Size(69, 16);
            this.lblbasimyili.TabIndex = 3;
            this.lblbasimyili.Text = "Basım Yılı:";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(102, 230);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(104, 16);
            this.lblkategori.TabIndex = 4;
            this.lblkategori.Text = "Kategori Seçimi:";
            // 
            // lblyayinevi
            // 
            this.lblyayinevi.AutoSize = true;
            this.lblyayinevi.Location = new System.Drawing.Point(102, 277);
            this.lblyayinevi.Name = "lblyayinevi";
            this.lblyayinevi.Size = new System.Drawing.Size(110, 16);
            this.lblyayinevi.TabIndex = 5;
            this.lblyayinevi.Text = "Yayın Evi Seçimi:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(219, 55);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKitapAdi.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(219, 106);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 7;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(219, 151);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtSayfaSayisi.TabIndex = 8;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(219, 188);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(100, 22);
            this.txtBasimYili.TabIndex = 9;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(219, 222);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKategori.TabIndex = 10;
            // 
            // comboBoxYayinevi
            // 
            this.comboBoxYayinevi.FormattingEnabled = true;
            this.comboBoxYayinevi.Location = new System.Drawing.Point(219, 274);
            this.comboBoxYayinevi.Name = "comboBoxYayinevi";
            this.comboBoxYayinevi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYayinevi.TabIndex = 12;
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(592, 3);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.RowTemplate.Height = 24;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(396, 306);
            this.dataGridViewKitaplar.TabIndex = 13;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(437, 349);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(136, 110);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(592, 349);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(141, 110);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(766, 349);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 110);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(930, 349);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 110);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Location = new System.Drawing.Point(200, 312);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtStokAdedi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stok Adedi:";
            // 
            // FormKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 526);
            this.Controls.Add(this.txtStokAdedi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.Controls.Add(this.comboBoxYayinevi);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblyayinevi);
            this.Controls.Add(this.lblkategori);
            this.Controls.Add(this.lblbasimyili);
            this.Controls.Add(this.lblsayfa);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lblkitapadi);
            this.Name = "FormKitap";
            this.Text = "FormKitap";
            this.Load += new System.EventHandler(this.FormKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkitapadi;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Label lblsayfa;
        private System.Windows.Forms.Label lblbasimyili;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.Label lblyayinevi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.ComboBox comboBoxYayinevi;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.Label label1;
    }
}