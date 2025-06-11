using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _241103005_Oguz_Altinisik_Nesne
{
    public partial class FormAnacs : Form
    {
        private string Email;

        public FormAnacs(string email)
        {
            InitializeComponent();
            Email =email;
            lblHosgeldiniz.Text = "Hoş geldiniz, " + email;
        }
        // 4.Kural Constructor (Yapıcı Metot): Tüm değişkenlere ilk değer ataması için yapıcı metot kullanın.
        public FormAnacs() : this("Ziyaretçi")
        {
            // Bu constructor, Designer ya da doğrudan açmak için kullanılır.
        }
        private void btnKitapYonetimi_Click(object sender, EventArgs e)
        {
            FormKitap kitapForm = new FormKitap(Email);
            kitapForm.ShowDialog();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            FormKullanici kullaniciForm = new FormKullanici(Email);
            kullaniciForm.ShowDialog();
        }

        private void btnOduncIslemleri_Click(object sender, EventArgs e)
        {
            FormOdunc oduncForm = new FormOdunc();
            oduncForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FormAnacs_Load(object sender, EventArgs e)
        {

        }
    }
}
