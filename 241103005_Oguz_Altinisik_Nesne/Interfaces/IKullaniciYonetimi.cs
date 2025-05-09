namespace _241103005_Oguz_Altinisik_Nesne.Interfaces
{
    internal interface IKullaniciYonetimi
    {
        void KullaniciEkle(string ad, string soyad, string email, string sifre);
        void KullaniciSil(string email);
        void KullaniciGuncelle(int kullaniciID, string ad, string soyad, string email, string sifre);  // KullaniciID eklendi!
    }
}
