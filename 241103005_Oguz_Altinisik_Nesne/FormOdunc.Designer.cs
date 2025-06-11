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
            this.btnAna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKullanici.Location = new System.Drawing.Point(88, 145);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(89, 28);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı:";
            // 
            // dgvOduncListe
            // 
            this.dgvOduncListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncListe.Location = new System.Drawing.Point(631, 57);
            this.dgvOduncListe.Name = "dgvOduncListe";
            this.dgvOduncListe.RowHeadersWidth = 51;
            this.dgvOduncListe.RowTemplate.Height = 24;
            this.dgvOduncListe.Size = new System.Drawing.Size(770, 254);
            this.dgvOduncListe.TabIndex = 1;
            this.dgvOduncListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOduncListe_CellClick);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKitap.Location = new System.Drawing.Point(88, 191);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(62, 28);
            this.lblKitap.TabIndex = 2;
            this.lblKitap.Text = "Kitap:";
            // 
            // lblodunc
            // 
            this.lblodunc.AutoSize = true;
            this.lblodunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblodunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblodunc.Location = new System.Drawing.Point(52, 240);
            this.lblodunc.Name = "lblodunc";
            this.lblodunc.Size = new System.Drawing.Size(125, 28);
            this.lblodunc.TabIndex = 3;
            this.lblodunc.Text = "Ödünç Tarihi:";
            // 
            // lbliade
            // 
            this.lbliade.AutoSize = true;
            this.lbliade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbliade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbliade.Location = new System.Drawing.Point(52, 283);
            this.lbliade.Name = "lbliade";
            this.lbliade.Size = new System.Drawing.Size(104, 28);
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
            this.dtpOduncTarihi.Location = new System.Drawing.Point(197, 245);
            this.dtpOduncTarihi.Name = "dtpOduncTarihi";
            this.dtpOduncTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOduncTarihi.TabIndex = 7;
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Location = new System.Drawing.Point(197, 289);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIadeTarihi.TabIndex = 8;
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOduncVer.FlatAppearance.BorderSize = 0;
            this.btnOduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduncVer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOduncVer.ForeColor = System.Drawing.Color.White;
            this.btnOduncVer.Location = new System.Drawing.Point(681, 339);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(141, 135);
            this.btnOduncVer.TabIndex = 9;
            this.btnOduncVer.Text = "ÖDÜNÇ VER";
            this.btnOduncVer.UseVisualStyleBackColor = false;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnIadeEt.FlatAppearance.BorderSize = 0;
            this.btnIadeEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIadeEt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIadeEt.ForeColor = System.Drawing.Color.White;
            this.btnIadeEt.Location = new System.Drawing.Point(935, 339);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(143, 135);
            this.btnIadeEt.TabIndex = 11;
            this.btnIadeEt.Text = "İADE ET";
            this.btnIadeEt.UseVisualStyleBackColor = false;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.Color.White;
            this.btnAna.Location = new System.Drawing.Point(1192, 339);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(139, 135);
            this.btnAna.TabIndex = 35;
            this.btnAna.Text = "ANA SAYFAYA DÖN";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // FormOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1455, 691);
            this.Controls.Add(this.btnAna);
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
        private System.Windows.Forms.Button btnAna;
    }
}