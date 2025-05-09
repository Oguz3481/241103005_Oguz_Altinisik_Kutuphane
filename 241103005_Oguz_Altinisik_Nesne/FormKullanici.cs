using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using _241103005_Oguz_Altinisik_Nesne.Interfaces;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class FormKullanici : Form, IKullaniciYonetimi
    {
        private string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormKullanici()
        {
            InitializeComponent();
        }

        public void KullaniciEkle(string ad, string soyad, string email, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre) VALUES (@Ad, @Soyad, @Email, @Sifre)", conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sifre", sifre);  // Telefon kaldırıldı

                cmd.ExecuteNonQuery();
            }

            Listele();
            MessageBox.Show("Kullanıcı başarıyla eklendi!");
        }

        public void KullaniciSil(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);

                cmd.ExecuteNonQuery();
            }

            Listele();
            MessageBox.Show("Kullanıcı başarıyla silindi!");
        }
        public void KullaniciGuncelle(int kullaniciID, string ad, string soyad, string email, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Ad = @Ad, Soyad = @Soyad, Email = @Email, Sifre = @Sifre WHERE KullaniciID = @KullaniciID", conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Email", email);  // Artık email değiştirilebilecek!
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);  // KullaniciID üzerinden değişiklik yapıyoruz

                cmd.ExecuteNonQuery();
            }

            Listele();
            MessageBox.Show("Kullanıcı başarıyla güncellendi!");
        }

        private void FormKullanici_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT KullaniciID, Ad, Soyad, Email FROM Kullanicilar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKullanicilar.DataSource = dt;
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle(txtAd.Text, txtSoyad.Text, txtEmail.Text, txtSifre.Text); // Şifre TextBox eklenmeli
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                string email = dataGridViewKullanicilar.SelectedRows[0].Cells["Email"].Value.ToString();
                KullaniciSil(email);
            }
        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridViewKullanicilar.Rows[e.RowIndex];

                txtAd.Text = satir.Cells["Ad"].Value.ToString();
                txtSoyad.Text = satir.Cells["Soyad"].Value.ToString();
                txtEmail.Text = satir.Cells["Email"].Value.ToString();
                txtSifre.Text = ""; // Şifre veritabanından güvenlik için çekilmiyor
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                int kullaniciID = Convert.ToInt32(dataGridViewKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value); // ID'yi alıyoruz
                string email = txtEmail.Text; // Kullanıcı yeni email girerse bunu alacağız!
                KullaniciGuncelle(kullaniciID, txtAd.Text, txtSoyad.Text, email, txtSifre.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!");
            }
        }

    }
}
