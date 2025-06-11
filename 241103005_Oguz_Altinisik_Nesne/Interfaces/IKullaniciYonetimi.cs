using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241103005_Oguz_Altinisik_Nesne.Interfaces
{
    internal interface IKullaniciYonetimi
    {
        
        void KullaniciSil(string email);
        void KullaniciGuncelle(int kullaniciID, string ad, string soyad, string email, string sifre);
    }
}
