using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsüller__property_
{
    internal class Program
    {
        // prop yazıp 2 kere tab bas

        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();

            musteri1.KİLO = 85; // değer atama yapıyorum = set komutları çalışır.
                                // eğer değer ataması yapmasaydım get komutları çalışırdı.

            Console.WriteLine(musteri1.KİLO);

            Console.ReadLine();
        }
    }
}
