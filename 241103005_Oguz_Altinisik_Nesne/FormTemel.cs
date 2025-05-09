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
    public partial class FormTemel : Form
    {
        public FormTemel()
        {
            InitializeComponent();
        }

        private void FormTemel_Load(object sender, EventArgs e)
        {

        }
        
        public virtual void Kaydet()
        {
            MessageBox.Show("Kayıt işlemi temel olarak yapıldı.");
        }
    }
}
