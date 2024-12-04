using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isci isci1 = new Isci();
            isci1.bilgileriGoster();
            Console.WriteLine(isci1.id);
            Console.WriteLine(isci1.isim);
            isci1.soyisim = "Bayram";  // değer atadik
            Console.WriteLine(isci1.soyisim); // atanan değeri aldık


            Console.ReadLine();
        }
    }
}
