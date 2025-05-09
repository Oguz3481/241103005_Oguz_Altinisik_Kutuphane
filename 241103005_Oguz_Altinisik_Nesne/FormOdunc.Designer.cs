namespace _241103005_Oguz_Altinisik_Nesne
{
    partial class FormOdunc
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.dgvOduncListe = new System.Windows.Forms.DataGridView();
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblodunc = new System.Windows.Forms.Label();
            this.lbliade = new System.Windows.Forms.Label();
            this.cmbKullanici = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.dtpOduncTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.btnIadeEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(97, 158);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(59, 16);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı:";
            // 
            // dgvOduncListe
            // 
            this.dgvOduncListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncListe.Location = new System.Drawing.Point(715, 65);
            this.dgvOduncListe.Name = "dgvOduncListe";
            this.dgvOduncListe.RowHeadersWidth = 51;
            this.dgvOduncListe.RowTemplate.Height = 24;
            this.dgvOduncListe.Size = new System.Drawing.Size(341, 254);
            this.dgvOduncListe.TabIndex = 1;
            this.dgvOduncListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOduncListe_CellClick);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(97, 206);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(40, 16);
            this.lblKitap.TabIndex = 2;
            this.lblKitap.Text = "Kitap:";
            // 
            // lblodunc
            // 
            this.lblodunc.AutoSize = true;
            this.lblodunc.Location = new System.Drawing.Point(97, 252);
            this.lblodunc.Name = "lblodunc";
            this.lblodunc.Size = new System.Drawing.Size(86, 16);
            this.lblodunc.TabIndex = 3;
            this.lblodunc.Text = "Ödünç Tarihi:";
            // 
            // lbliade
            // 
            this.lbliade.AutoSize = true;
            this.lbliade.Location = new System.Drawing.Point(97, 294);
            this.lbliade.Name = "lbliade";
            this.lbliade.Size = new System.Drawing.Size(74, 16);
            this.lbliade.TabIndex = 4;
            this.lbliade.Text = "İade Tarihi:";
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.Location = new System.Drawing.Point(197, 149);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(121, 24);
            this.cmbKullanici.TabIndex = 5;
            // 
            // cmbKitap
            // 
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(197, 198);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(121, 24);
            this.cmbKitap.TabIndex = 6;
            // 
            // dtpOduncTarihi
            // 
            this.dtpOduncTarihi.Location = new System.Drawing.Point(228, 245);
            this.dtpOduncTarihi.Name = "dtpOduncTarihi";
            this.dtpOduncTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOduncTarihi.TabIndex = 7;
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Location = new System.Drawing.Point(197, 288);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIadeTarihi.TabIndex = 8;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.Location = new System.Drawing.Point(378, 389);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(238, 163);
            this.btnOduncVer.TabIndex = 9;
            this.btnOduncVer.Text = "ÖDÜNÇ VER";
            this.btnOduncVer.UseVisualStyleBackColor = true;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(669, 389);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(238, 163);
            this.btnIadeEt.TabIndex = 11;
            this.btnIadeEt.Text = "İADE ET";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // FormOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 691);
            this.Controls.Add(this.btnIadeEt);
            this.Controls.Add(this.btnOduncVer);
            this.Controls.Add(this.dtpIadeTarihi);
            this.Controls.Add(this.dtpOduncTarihi);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.cmbKullanici);
            this.Controls.Add(this.lbliade);
            this.Controls.Add(this.lblodunc);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.dgvOduncListe);
            this.Controls.Add(this.lblKullanici);
            this.Name = "FormOdunc";
            this.Text = "FormOdunc";
            this.Load += new System.EventHandler(this.FormOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.DataGridView dgvOduncListe;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblodunc;
        private System.Windows.Forms.Label lbliade;
        private System.Windows.Forms.ComboBox cmbKullanici;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.DateTimePicker dtpOduncTarihi;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Button btnIadeEt;
    }
}