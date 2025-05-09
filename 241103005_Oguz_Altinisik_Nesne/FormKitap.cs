using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class FormKitap : Form
    {
        public FormKitap()
        {
            InitializeComponent();
            LoadCategories();
            LoadPublishers();
        }

        private void FormKitap_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT KategoriID, Ad FROM Kategoriler", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboBoxKategori.DataSource = dt;
                comboBoxKategori.DisplayMember = "Ad";  // Kullanıcıya "Ad" göster
                comboBoxKategori.ValueMember = "KategoriID";  // ID sakla
            }
        }

        private void LoadPublishers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT YayineviID, Ad FROM Yayinevleri", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                comboBoxYayinevi.DataSource = dt;
                comboBoxYayinevi.DisplayMember = "Ad";  // Kullanıcıya "Ad" göster
                comboBoxYayinevi.ValueMember = "YayineviID";  // ID sakla
            }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text;
            string isbn = txtISBN.Text;
            int sayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            int basimYili = int.Parse(txtBasimYili.Text);
            string kategori = comboBoxKategori.SelectedItem.ToString();
            string yayinevi = comboBoxYayinevi.SelectedItem.ToString();
            int stokAdedi = int.Parse(txtStokAdedi.Text); // Kullanıcı stok adedi giriyor

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Kitaplar (Ad, ISBN, SayfaSayisi, BasimYili, KategoriID, YayineviID, StokAdedi) 
                                          VALUES (@Ad, @ISBN, @SayfaSayisi, @BasimYili, 
                                          (SELECT KategoriID FROM Kategoriler WHERE Ad = @Kategori), 
                                          (SELECT YayineviID FROM Yayinevleri WHERE Ad = @Yayinevi), @StokAdedi)", conn);

                cmd.Parameters.AddWithValue("@Ad", kitapAdi);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                cmd.Parameters.AddWithValue("@BasimYili", basimYili);
                cmd.Parameters.AddWithValue("@Kategori", kategori);
                cmd.Parameters.AddWithValue("@Yayinevi", yayinevi);
                cmd.Parameters.AddWithValue("@StokAdedi", stokAdedi);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kitap başarıyla eklendi.");
            ClearFields();
            LoadBooks();
        }


        private void LoadBooks()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT KitapID, Ad, ISBN, SayfaSayisi, BasimYili,YayineviID, KategoriID, StokAdedi FROM Kitaplar", conn);
                da.Fill(dt);
            }
            dataGridViewKitaplar.DataSource = dt;
        }


        // Formu temizleme
        private void ClearFields()
        {
            txtKitapAdi.Clear();
            txtISBN.Clear();
            txtSayfaSayisi.Clear();
            txtBasimYili.Clear();
            comboBoxKategori.SelectedIndex = -1;
            comboBoxYayinevi.SelectedIndex = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count > 0)
            {
                object kitapIdObj = dataGridViewKitaplar.SelectedRows[0].Cells["KitapID"].Value;

                if (kitapIdObj == DBNull.Value || kitapIdObj == null)
                {
                    MessageBox.Show("Geçersiz kitap ID, silme işlemi yapılamıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // İşlemi durdur
                }

                int kitapId = Convert.ToInt32(kitapIdObj);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Önce stok adedini kontrol edelim
                    SqlCommand stokKontrol = new SqlCommand("SELECT StokAdedi FROM Kitaplar WHERE KitapID = @KitapID", conn);
                    stokKontrol.Parameters.AddWithValue("@KitapID", kitapId);
                    object stokObj = stokKontrol.ExecuteScalar();

                    if (stokObj == DBNull.Value || stokObj == null)
                    {
                        MessageBox.Show("Bu kitap bulunamadı, silme işlemi yapılamıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int stokAdedi = Convert.ToInt32(stokObj);

                    if (stokAdedi > 1)
                    {
                        // Stok miktarını azalt
                        SqlCommand guncelleStok = new SqlCommand("UPDATE Kitaplar SET StokAdedi = StokAdedi - 1 WHERE KitapID = @KitapID", conn);
                        guncelleStok.Parameters.AddWithValue("@KitapID", kitapId);
                        guncelleStok.ExecuteNonQuery();
                        MessageBox.Show("Kitap adedi güncellendi! Yeni stok: " + (stokAdedi - 1));
                    }
                    else
                    {
                        // Eğer stok 1 ise kitabı tamamen sil
                        SqlCommand silKitap = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID = @KitapID", conn);
                        silKitap.Parameters.AddWithValue("@KitapID", kitapId);
                        silKitap.ExecuteNonQuery();
                        MessageBox.Show("Kitap tamamen kaldırıldı.");
                    }
                }

                LoadBooks();
            }
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewKitaplar.SelectedRows.Count > 0)
            {
                int kitapId = Convert.ToInt32(dataGridViewKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                string kitapAdi = txtKitapAdi.Text;
                string isbn = txtISBN.Text;
                int sayfaSayisi = int.Parse(txtSayfaSayisi.Text);
                int basimYili = int.Parse(txtBasimYili.Text);
                int kategoriId = Convert.ToInt32(comboBoxKategori.SelectedValue);  // ID'yi alıyoruz
                int yayineviId = Convert.ToInt32(comboBoxYayinevi.SelectedValue);  // ID'yi alıyoruz
                int stokAdedi = int.Parse(txtStokAdedi.Text);  // Stok miktarını güncellemek için

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET Ad = @Ad, ISBN = @ISBN, SayfaSayisi = @SayfaSayisi, " +
                        "BasimYili = @BasimYili, KategoriID = @KategoriID, YayineviID = @YayineviID, StokAdedi = @StokAdedi WHERE KitapID = @KitapID", conn);

                    cmd.Parameters.AddWithValue("@Ad", kitapAdi);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                    cmd.Parameters.AddWithValue("@BasimYili", basimYili);
                    cmd.Parameters.AddWithValue("@KategoriID", kategoriId);  // Artık ID kullanıyoruz
                    cmd.Parameters.AddWithValue("@YayineviID", yayineviId);  // Artık ID kullanıyoruz
                    cmd.Parameters.AddWithValue("@StokAdedi", stokAdedi);  // Stok güncelleme eklendi
                    cmd.Parameters.AddWithValue("@KitapID", kitapId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap başarıyla güncellendi.");
                    LoadBooks(); // Listeyi güncelle
                }
            }
        }


        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Eğer geçerli bir satıra tıklanmışsa
            {
                DataGridViewRow satir = dataGridViewKitaplar.Rows[e.RowIndex];

                // TextBox'lara verileri atama
                txtKitapAdi.Text = satir.Cells["Ad"].Value.ToString();
                txtISBN.Text = satir.Cells["ISBN"].Value.ToString();
                txtSayfaSayisi.Text = satir.Cells["SayfaSayisi"].Value.ToString();
                txtBasimYili.Text = satir.Cells["BasimYili"].Value.ToString();

                // ComboBox'lara verileri atama
                comboBoxKategori.SelectedItem = satir.Cells["KategoriID"].Value.ToString();
                comboBoxYayinevi.SelectedItem = satir.Cells["YayineviID"].Value.ToString();
            }
        }
    }
}
