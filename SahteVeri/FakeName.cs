using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{

    class FakeName
    {
        Random rnd;
        public FakeName()
        {
            rnd = new Random();
        }
        public string Karmaisim()
        {
            string[] isimlst = { "Ali", "Veli", "Güneş", "Hatice", "Tuğba", "Faruk", "Ömer", "Filiz", "Selin", "Anıl", "Hasibe", "Melih" };
            int rnd2 = rnd.Next(0, 12);
            return isimlst[rnd2];
        }
        public string Karmasoyisim()
        {
            string[] soyİsimlst = { "Yıldız", "Aydın", "Kaya", "Demir", "Şahin", "Çelik", "Karaca", "Yıldırım", "Koray", "Kenter", "Gül", "Menekşe" };
            int rnd2 = rnd.Next(0, 12);
            return soyİsimlst[rnd2];
        }
    }
}
