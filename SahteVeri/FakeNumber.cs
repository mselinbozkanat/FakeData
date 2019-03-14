using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    class FakeNumber
    {
        
        
          
        Random rnd;
        public FakeNumber()
        {
            rnd = new Random();
        }
        public int Karmayas()
        { 
            int yas = rnd.Next(18, 90);
            return yas ;
        }
        public int Karmanumber()
        {
            int[] numberlst = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int rnd2 = rnd.Next(0, 10);
            return numberlst[rnd2];
        }
        public string TelNoUret()
        {
            int telNo = +rnd.Next(10000000, 99999999);
            string telNoTam = "053" + Convert.ToInt32(telNo);
            return telNoTam;
        }
    }
}
