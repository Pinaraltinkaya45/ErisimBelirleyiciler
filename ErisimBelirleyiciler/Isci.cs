using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
    public class Isci
    {
        public int id = 1;
        public string isim = "Sercan";
        public string soyisim { get;set; }

        public void bilgileriGoster()
        {
            Console.WriteLine("İşci: " + id);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);

        }

        public void deneme()
        {
            Console.WriteLine("deneme");
        }
    }
}
