namespace _241103005_Oguz_Altinisik_Nesne
{
    partial class FormAnacs
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
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.btnKitapYonetimi = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOduncIslemleri = new System.Windows.Forms.Button();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.Location = new System.Drawing.Point(505, 9);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(411, 158);
            this.lblHosgeldiniz.TabIndex = 0;
            // 
            // btnKitapYonetimi
            // 
            this.btnKitapYonetimi.Location = new System.Drawing.Point(182, 267);
            this.btnKitapYonetimi.Name = "btnKitapYonetimi";
            this.btnKitapYonetimi.Size = new System.Drawing.Size(157, 150);
            this.btnKitapYonetimi.TabIndex = 1;
            this.btnKitapYonetimi.Text = "Kitap Yönetimi";
            this.btnKitapYonetimi.UseVisualStyleBackColor = true;
            this.btnKitapYonetimi.Click += new System.EventHandler(this.btnKitapYonetimi_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(815, 267);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(155, 150);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOduncIslemleri
            // 
            this.btnOduncIslemleri.Location = new System.Drawing.Point(586, 267);
            this.btnOduncIslemleri.Name = "btnOduncIslemleri";
            this.btnOduncIslemleri.Size = new System.Drawing.Size(180, 150);
            this.btnOduncIslemleri.TabIndex = 3;
            this.btnOduncIslemleri.Text = "Ödünç İşlemleri";
            this.btnOduncIslemleri.UseVisualStyleBackColor = true;
            this.btnOduncIslemleri.Click += new System.EventHandler(this.btnOduncIslemleri_Click);
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(382, 267);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(163, 150);
            this.btnKullaniciYonetimi.TabIndex = 4;
            this.btnKullaniciYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetimi.UseVisualStyleBackColor = true;
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // FormAnacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 773);
            this.Controls.Add(this.btnKullaniciYonetimi);
            this.Controls.Add(this.btnOduncIslemleri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKitapYonetimi);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Name = "FormAnacs";
            this.Text = "FormAnacs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Button btnKitapYonetimi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOduncIslemleri;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
    }
}