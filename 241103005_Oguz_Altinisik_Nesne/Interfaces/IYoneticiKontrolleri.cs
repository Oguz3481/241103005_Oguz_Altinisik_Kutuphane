using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241103005_Oguz_Altinisik_Nesne.Interfaces
{
    internal interface IYoneticiKontrolleri:IKullaniciYonetimi
    {
        void YetkiTanit(string email, string rol);
    }
}
