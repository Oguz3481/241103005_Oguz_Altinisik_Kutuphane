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
        public FormAnacs() : this("Ziyaretçi")
        {
            // Bu constructor, Designer ya da doğrudan açmak için kullanılır.
        }
        private void btnKitapYonetimi_Click(object sender, EventArgs e)
        {
            FormKitap kitapForm = new FormKitap();
            kitapForm.ShowDialog();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            FormKullanici kullaniciForm = new FormKullanici();
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


    }
}
