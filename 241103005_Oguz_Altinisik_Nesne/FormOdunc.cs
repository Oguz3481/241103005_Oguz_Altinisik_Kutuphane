using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class FormOdunc : Form
    {
        private string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormOdunc()
        {
            InitializeComponent();
        }

        private void FormOdunc_Load(object sender, EventArgs e)
        {
            KullaniciYukle();
            KitapYukle();
            Listele();
        }

        private void KullaniciYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT KullaniciID, Ad + ' ' + Soyad AS AdSoyad FROM Kullanicilar", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbKullanici.DataSource = dt;
                cmbKullanici.DisplayMember = "AdSoyad";
                cmbKullanici.ValueMember = "KullaniciID";
            }
        }

        private void KitapYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT KitapID, Ad FROM Kitaplar", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbKitap.DataSource = dt;
                cmbKitap.DisplayMember = "Ad";
                cmbKitap.ValueMember = "KitapID";
            }
        }

        private void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    O.IslemID, 
                                    K.Ad + ' ' + K.Soyad AS Kullanici, 
                                    KT.Ad AS Kitap, 
                                    O.AlisTarihi, 
                                    O.IadeTarihi,
                                    O.TeslimEdildi
                                 FROM OduncIslemleri O
                                 JOIN Kullanicilar K ON O.KullaniciID = K.KullaniciID
                                 JOIN Kitaplar KT ON O.KitapID = KT.KitapID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOduncListe.DataSource = dt;
            }
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(cmbKullanici.SelectedValue);
            int kitapID = Convert.ToInt32(cmbKitap.SelectedValue);
            DateTime oduncTarihi = dtpOduncTarihi.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO OduncIslemleri (KullaniciID, KitapID, AlisTarihi) VALUES (@KullaniciID, @KitapID, @AlisTarihi)", conn);
                cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                cmd.Parameters.AddWithValue("@KitapID", kitapID);
                cmd.Parameters.AddWithValue("@AlisTarihi", oduncTarihi);
                cmd.ExecuteNonQuery();
            }

            Listele();
            MessageBox.Show("Kitap ödünç verildi.");
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncListe.SelectedRows.Count > 0)
            {
                int islemID = Convert.ToInt32(dgvOduncListe.SelectedRows[0].Cells["IslemID"].Value);
                DateTime iadeTarihi = dtpIadeTarihi.Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE OduncIslemleri SET IadeTarihi = @IadeTarihi, TeslimEdildi = 1 WHERE IslemID = @IslemID", conn);
                    cmd.Parameters.AddWithValue("@IadeTarihi", iadeTarihi);
                    cmd.Parameters.AddWithValue("@IslemID", islemID);
                    cmd.ExecuteNonQuery();
                }

                Listele();
                MessageBox.Show("Kitap iade edildi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir ödünç kaydı seçin.");
            }
        }

        private void dgvOduncListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satıra tıklanmışsa
            {
                DataGridViewRow satir = dgvOduncListe.Rows[e.RowIndex];

                // ComboBox'lara verileri atama
                cmbKullanici.SelectedItem = satir.Cells["Kullanici"].Value.ToString();
                cmbKitap.SelectedItem = satir.Cells["Kitap"].Value.ToString();

                // DateTimePicker'a verileri atama (Tarihleri uygun formatta ayarlamak için)
                if (satir.Cells["AlisTarihi"].Value != DBNull.Value)
                    dtpOduncTarihi.Value = Convert.ToDateTime(satir.Cells["AlisTarihi"].Value);

                if (satir.Cells["IadeTarihi"].Value != DBNull.Value)
                    dtpIadeTarihi.Value = Convert.ToDateTime(satir.Cells["IadeTarihi"].Value);
            }
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            FormAnacs anasayfa = new FormAnacs();
            anasayfa.Show();
            this.Hide();
        }
    }
}