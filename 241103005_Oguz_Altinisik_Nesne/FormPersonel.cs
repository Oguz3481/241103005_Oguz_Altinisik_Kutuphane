using _241103005_Oguz_Altinisik_Nesne.Interfaces;
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
    public partial class FormPersonel : Form, IGuncelle, ISil, IListele
    {
        private SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public FormPersonel()
        {
            InitializeComponent();
        }
        public void Ekle()
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Personeller (Ad, Soyad, Email, Gorev) VALUES (@Ad, @Soyad, @Email, @Gorev)", baglanti);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.Parameters.AddWithValue("@Gorev", txtGorev.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele(dataGridView1);
        }
        public void Guncelle(int id)
        {
            SqlCommand komut = new SqlCommand("UPDATE Personeller SET Ad=@Ad, Soyad=@Soyad, Email=@Email, Gorev=@Gorev WHERE PersonelID=@ID", baglanti);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.Parameters.AddWithValue("@Gorev", txtGorev.Text);
            komut.Parameters.AddWithValue("@ID", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele(dataGridView1);
        }

        public void Sil(int id)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE PersonelID=@ID", baglanti);
            komut.Parameters.AddWithValue("@ID", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele(dataGridView1);
        }

        public void Listele(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele(dataGridView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Guncelle(id);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Sil(id);
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            Listele(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["PersonelID"].Value.ToString();
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtGorev.Text = row.Cells["Gorev"].Value.ToString();
            }
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            FormAnacs anasayfa = new FormAnacs();
            anasayfa.Show();
            this.Hide(); // FormPersonel'i kapatmak yerine gizliyoruz
        }
    }
}
