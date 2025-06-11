using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241103005_Oguz_Altinisik_Nesne //3.kural  Sınıflarda private değişkenler tanımlayın ve erişim için property'ler kullanın.
                                          // 8.Kural  En az bir statik değişken ve bir statik metot ekleyin.asd

{
    public static class GirisYapanKullanici
    {
        public static int KullaniciID { get; set; }
        public static string Email { get; set; }
    }
}
