using _241103005_Oguz_Altinisik_Nesne.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _241103005_Oguz_Altinisik_Nesne
{
    internal class PersonelSilmeIslemi : ISil //2.Kural : IInterface2 ve IInterface3'ü uygulayan iki sınıf oluşturun
    {
        private SqlConnection baglanti;
        private DataGridView dgv;

        public PersonelSilmeIslemi(SqlConnection baglanti, DataGridView dgv)
        {
            this.baglanti = baglanti;
            this.dgv = dgv;
        }

        public void Sil(int id)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE PersonelID=@ID", baglanti);
            komut.Parameters.AddWithValue("@ID", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
