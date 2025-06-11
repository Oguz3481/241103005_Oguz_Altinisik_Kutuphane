using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using _241103005_Oguz_Altinisik_Nesne.Interfaces;

namespace _241103005_Oguz_Altinisik_Nesne.Classlar
{
    internal class PersonelListelemeIslemi : IListele    // 2.Kural : IInterface2 ve IInterface3'ü uygulayan iki sınıf oluşturun
    {
        private SqlConnection _baglanti;

        public PersonelListelemeIslemi(SqlConnection baglanti)
        {
            _baglanti = baglanti;
        }

        public void Listele(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personeller", _baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
