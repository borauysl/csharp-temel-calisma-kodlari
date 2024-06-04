using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_değişken_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            personel p1 = new personel();

            p1.calisanid = 1;
            p1.isim = "Bora";
            p1.soyisim = "Uysal";

            personel.maas = 2500;

            Console.WriteLine("************************************");

            Console.WriteLine("Çalışan id :"+p1.calisanid);
            Console.WriteLine("Çalışan isim :"+p1.isim);
            Console.WriteLine("Çalışan Soy isim"+p1.soyisim);
            Console.WriteLine("Çalışan maaşı :"+personel.maas);

            Console.WriteLine("************************************");

            Console.ReadLine();


        }
    }
}
