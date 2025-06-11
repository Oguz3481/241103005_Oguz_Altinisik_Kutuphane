using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class KayitOlForm : FormTemel  // Base class'tan miras alınıyor
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }

        // 6.KURAL Method Overriding:Kaydet metodunu ezdik!
        public override void Kaydet()
        {
            string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar (Ad, Soyad, Email, Sifre, Telefon, UyeTarihi) VALUES (@Ad, @Soyad, @Email, @Sifre, @Telefon, @UyeTarihi)", conn);
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@UyeTarihi", DateTime.Now);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı!");
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();  // Artık `override` edilmiş metot çağrılıyor!
        }
    }
}