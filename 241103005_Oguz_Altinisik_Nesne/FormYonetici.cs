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
            KitaplariListele();

            cmbRol.Items.Clear();
            cmbRol.Items.Add("Uye");
            cmbRol.Items.Add("Yonetici");
            cmbRol.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kategori
                SqlDataAdapter daKat = new SqlDataAdapter("SELECT KategoriID, Ad FROM Kategoriler", conn);
                DataTable dtKat = new DataTable();
                daKat.Fill(dtKat);
                cmbKategori.DataSource = dtKat;
                cmbKategori.DisplayMember = "Ad";
                cmbKategori.ValueMember = "KategoriID";

                // Yayinevi
                SqlDataAdapter daYay = new SqlDataAdapter("SELECT YayineviID, Ad FROM Yayinevleri", conn);
                DataTable dtYay = new DataTable();
                daYay.Fill(dtYay);
                cmbYayinevi.DataSource = dtYay;
                cmbYayinevi.DisplayMember = "Ad";
                cmbYayinevi.ValueMember = "YayineviID";
            }
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
                int kullaniciId = Convert.ToInt32(dataGridViewKullanicilar.SelectedRows[0].Cells["KullaniciID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Önce bağlı ödünç kayıtlarını kaldır
                    SqlCommand cmdOduncSil = new SqlCommand("DELETE FROM OduncIslemleri WHERE KullaniciID = @KullaniciID", conn);
                    cmdOduncSil.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                    cmdOduncSil.ExecuteNonQuery();

                    // Şimdi kullanıcıyı güvenle silebiliriz
                    SqlCommand cmdSil = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID", conn);
                    cmdSil.Parameters.AddWithValue("@KullaniciID", kullaniciId);
                    cmdSil.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı ve bağlı ödünç işlemleri başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Kullanıcı yetkisi başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
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
                cmbRol.SelectedItem = satir.Cells["Rol"].Value.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FormAnacs anasayfa = new FormAnacs();
            anasayfa.Show();
            this.Hide(); // FormPersonel'i kapatmak yerine gizliyoruz
        }
        private void KitaplariListele()
        {
            button1_Click(null, null);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAd.Text) || string.IsNullOrWhiteSpace(txtISBN.Text) ||
        string.IsNullOrWhiteSpace(txtSayfaSayisi.Text) || string.IsNullOrWhiteSpace(txtBasimYili.Text) ||
        cmbKategori.SelectedItem == null || cmbYayinevi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Kitaplar 
    (Ad, ISBN, SayfaSayisi, BasimYili, KategoriID, YayineviID, StokAdedi)
    VALUES (@Ad, @ISBN, @SayfaSayisi, @BasimYili, @KategoriID, @YayineviID, @StokAdedi)", conn);

                cmd.Parameters.AddWithValue("@Ad", txtKitapAd.Text);
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@SayfaSayisi", int.Parse(txtSayfaSayisi.Text));
                cmd.Parameters.AddWithValue("@BasimYili", int.Parse(txtBasimYili.Text));
                cmd.Parameters.AddWithValue("@KategoriID", cmbKategori.SelectedValue);
                cmd.Parameters.AddWithValue("@YayineviID", cmbYayinevi.SelectedValue);
                cmd.Parameters.AddWithValue("@StokAdedi", int.Parse(txtStokAdedi.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1_Click(null, null); // Listeyi güncelle
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count > 0)
            {
                int kitapId = Convert.ToInt32(dataGridViewKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                int stokAdedi = Convert.ToInt32(dataGridViewKitaplar.SelectedRows[0].Cells["StokAdedi"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (stokAdedi > 0)
                    {
                        // Stok 1 azaltılır
                        SqlCommand updateCmd = new SqlCommand("UPDATE Kitaplar SET StokAdedi = StokAdedi - 1 WHERE KitapID = @KitapID", conn);
                        updateCmd.Parameters.AddWithValue("@KitapID", kitapId);
                        updateCmd.ExecuteNonQuery();

                        // Güncel stok değerini tekrar al
                        SqlCommand checkCmd = new SqlCommand("SELECT StokAdedi FROM Kitaplar WHERE KitapID = @KitapID", conn);
                        checkCmd.Parameters.AddWithValue("@KitapID", kitapId);
                        int yeniStok = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (yeniStok == 0)
                        {
                            // Stok 0 olduysa kitabı sil
                            SqlCommand deleteCmd = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID = @KitapID", conn);
                            deleteCmd.Parameters.AddWithValue("@KitapID", kitapId);
                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Stok 0'a düştü. Kitap tamamen silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kitabın stok adedi 1 azaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Zaten stok 0 ise, doğrudan sil
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID = @KitapID", conn);
                        deleteCmd.Parameters.AddWithValue("@KitapID", kitapId);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Stok zaten 0'dı. Kitap tamamen silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                button1_Click(null, null); // Listeyi yenile
            }
        }





        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count > 0)
            {
                int kitapId = Convert.ToInt32(dataGridViewKitaplar.SelectedRows[0].Cells["KitapID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Kitaplar 
    SET Ad = @Ad, ISBN = @ISBN, SayfaSayisi = @SayfaSayisi,
        BasimYili = @BasimYili, KategoriID = @KategoriID, YayineviID = @YayineviID,
        StokAdedi = @StokAdedi
    WHERE KitapID = @KitapID", conn);


                    cmd.Parameters.AddWithValue("@Ad", txtKitapAd.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@SayfaSayisi", int.Parse(txtSayfaSayisi.Text));
                    cmd.Parameters.AddWithValue("@BasimYili", int.Parse(txtBasimYili.Text));
                    cmd.Parameters.AddWithValue("@KategoriID", cmbKategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@YayineviID", cmbYayinevi.SelectedValue);
                    cmd.Parameters.AddWithValue("@KitapID", kitapId);
                    cmd.Parameters.AddWithValue("@StokAdedi", int.Parse(txtStokAdedi.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kitap bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT k.KitapID, k.Ad, k.ISBN, k.SayfaSayisi, k.BasimYili, 
       kat.Ad AS Kategori, yv.Ad AS Yayinevi, k.StokAdedi
FROM Kitaplar k
INNER JOIN Kategoriler kat ON k.KategoriID = kat.KategoriID
INNER JOIN Yayinevleri yv ON k.YayineviID = yv.YayineviID
";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKitaplar.DataSource = dt;
            }
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridViewKitaplar.Rows[e.RowIndex];
                txtKitapAd.Text = satir.Cells["Ad"].Value.ToString();
                txtISBN.Text = satir.Cells["ISBN"].Value.ToString();
                txtSayfaSayisi.Text = satir.Cells["SayfaSayisi"].Value.ToString();
                txtBasimYili.Text = satir.Cells["BasimYili"].Value.ToString();
                cmbKategori.SelectedIndex = cmbKategori.FindString(satir.Cells["Kategori"].Value.ToString());
                cmbYayinevi.SelectedIndex = cmbYayinevi.FindString(satir.Cells["Yayinevi"].Value.ToString());

                txtStokAdedi.Text = satir.Cells["StokAdedi"].Value.ToString();

            }
        }

    }
}
