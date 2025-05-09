using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class LoginForm : Form
    {
        // Encapsulation: Bağlantı bilgisini özel hale getirdik
        private static readonly string connectionString = "Data Source=DESKTOP-6BEGMBC\\SQLEXPRESS;Initial Catalog=Oguz2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string _email;
        private string _sifre;

        // Constructor ile değişkenleri başlatıyoruz (Yapıcı Metot)
        public LoginForm()
        {
            InitializeComponent();
        }

        // Encapsulation: Email ve Şifre değişkenlerini private tutup property ile erişim sağlıyoruz
        private string Email
        {
            get => _email;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _email = value;
            }
        }

        private string Sifre
        {
            get => _sifre;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _sifre = value;
            }
        }

        // Method Overloading: Kullanıcı giriş kontrolünü farklı parametrelerle çalıştırabilen versiyonlar
        private bool GirisKontrol(string email, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Rol FROM Kullanicilar WHERE Email = @Email AND Sifre = @Sifre", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                var rol = cmd.ExecuteScalar()?.ToString();
                return rol != null;
            }
        }

        private bool GirisKontrol()
        {
            return GirisKontrol(Email, Sifre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Property’ler üzerinden giriş bilgilerini set ediyoruz
            Email = txtEmail.Text;
            Sifre = txtSifre.Text;

            if (GirisKontrol()) // Encapsulation ile private değişkenleri kullanıyoruz
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Rol FROM Kullanicilar WHERE Email = @Email AND Sifre = @Sifre", conn);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Sifre", Sifre);

                    var rol = cmd.ExecuteScalar()?.ToString();

                    if (rol == "Yonetici")
                    {
                        FormYonetici yoneticiPanel = new FormYonetici();
                        yoneticiPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormAnacs anaForm = new FormAnacs(Email);
                        anaForm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Email veya şifre hatalı!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            KayitOlForm kayitForm = new KayitOlForm();
            kayitForm.Show();
        }
    }
}
