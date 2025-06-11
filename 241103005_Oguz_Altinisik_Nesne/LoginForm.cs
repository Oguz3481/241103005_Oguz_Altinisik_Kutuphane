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
        public abstract class GirisliKullanici
        {
            protected string Email;
            public GirisliKullanici(string email)
            {
                Email = email;
            }

            public abstract void GirisYap(Form loginForm); // loginForm'u gizlemek için parametreyle yolluyoruz
        }

        public class Yonetici : GirisliKullanici
        {
            public Yonetici(string email) : base(email) { }

            public override void GirisYap(Form loginForm)
            {
                FormYonetici form = new FormYonetici();
                form.Show();
                loginForm.Hide();
            }
        }

        public class Personel : GirisliKullanici
        {
            public Personel(string email) : base(email) { }

            public override void GirisYap(Form loginForm)
            {
                FormPersonel form = new FormPersonel();
                form.Show();
                loginForm.Hide();
            }
        }

        public class Uye : GirisliKullanici
        {
            public Uye(string email) : base(email) { }

            public override void GirisYap(Form loginForm)
            {
                FormAnacs form = new FormAnacs(Email);
                form.Show();
                loginForm.Hide();
            }
        }
        private string GirisKontrolDetayli(string email, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Kullanicilar tablosunu kontrol et
                SqlCommand cmd1 = new SqlCommand("SELECT KullaniciID, Rol, Email FROM Kullanicilar WHERE Email = @Email AND Sifre = @Sifre", conn);
                cmd1.Parameters.AddWithValue("@Email", email);
                cmd1.Parameters.AddWithValue("@Sifre", sifre);

                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    GirisYapanKullanici.KullaniciID = Convert.ToInt32(reader["KullaniciID"]);
                    GirisYapanKullanici.Email = reader["Email"].ToString();
                    return reader["Rol"].ToString();
                }
                reader.Close();

                // 2. Personel kontrolü
                SqlCommand cmd2 = new SqlCommand("SELECT PersonelID, Email FROM Personeller WHERE Email = @Email AND Sifre = @Sifre", conn);
                cmd2.Parameters.AddWithValue("@Email", email);
                cmd2.Parameters.AddWithValue("@Sifre", sifre);

                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    // Gerekirse Personel bilgileri de saklanabilir
                    return "Personel";
                }
                return null;
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
            Email = txtEmail.Text;
            Sifre = txtSifre.Text;

            string rol = GirisKontrolDetayli(Email, Sifre);

            GirisliKullanici kullanici = null;

            if (rol == "Yonetici")
                kullanici = new Yonetici(Email);
            else if (rol == "Personel")
                kullanici = new Personel(Email);
            else if (rol == "Uye")
                kullanici = new Uye(Email);

            if (kullanici != null)
                kullanici.GirisYap(this);
            else
                MessageBox.Show("Email veya şifre hatalı!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        private void kayitbutton_Click(object sender, EventArgs e)
        {
            KayitOlForm kayitForm = new KayitOlForm();
            kayitForm.Show();
        }
    }
}
