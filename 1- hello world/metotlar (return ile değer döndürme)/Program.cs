using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar__return_ile_değer_döndürme_
{
    internal class Program
    {
        static void Main(string[] args)
        {

          int donendeger =  toplamayap(6, 7);

            if(donendeger>10)
            {
                Console.WriteLine("Değer 10 dan büyüktür");
            }
            else
            {
                Console.WriteLine("Değer 10 dan küçüktür");
            }
            Console.ReadLine();
        }

        static int toplamayap(int sayi1, int sayi2 )
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;
        }

    }
}
