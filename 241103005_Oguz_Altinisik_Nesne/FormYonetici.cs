using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class FormYonetici : Form
    {
        private string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormYonetici()
        {
            InitializeComponent();
        }

        private void FormYonetici_Load(object sender, EventArgs e)
        {
            Listele();
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Uye");
            cmbRol.Items.Add("Yonetici");
            cmbRol.SelectedIndex = 0; // Varsayılan olarak 'Uye' seçili olsun
        }

        private void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT KullaniciID, Ad, Soyad, Email, Rol FROM Kullanicilar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKullanicilar.DataSource = dt;
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre, Rol) VALUES (@Ad, @Soyad, @Email, @Sifre, 'Uye')", conn);
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                string email = dataGridViewKullanicilar.SelectedRows[0].Cells["Email"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Email = @Email", conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnYetkiGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanicilar.SelectedRows.Count > 0)
            {
                string email = dataGridViewKullanicilar.SelectedRows[0].Cells["Email"].Value.ToString();
                string rol = cmbRol.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Rol = @Rol WHERE Email = @Email", conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı yetkisi başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail2.Text) || string.IsNullOrWhiteSpace(txtsifre2.Text))
            {
                MessageBox.Show("Lütfen e-posta ve yeni şifreyi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Sifre = @YeniSifre WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", txtemail2.Text);
                cmd.Parameters.AddWithValue("@YeniSifre", txtsifre2.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Şifre başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnVeritabaniYedekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veritabanı yedeklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridViewKullanicilar.Rows[e.RowIndex];
                txtAd.Text = satir.Cells["Ad"].Value.ToString();
                txtSoyad.Text = satir.Cells["Soyad"].Value.ToString();
                txtEmail.Text = satir.Cells["Email"].Value.ToString();
                cmbRol.SelectedItem = satir.Cells["Rol"].Value.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
