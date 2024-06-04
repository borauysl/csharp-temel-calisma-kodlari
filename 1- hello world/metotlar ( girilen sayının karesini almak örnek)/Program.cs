using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar___girilen_sayının_karesini_almak_örnek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz :");

                int sayi = int.Parse(Console.ReadLine());

            int karedeger = kareal(sayi);

            if(karedeger>25)
            {
                Console.WriteLine("Kare değeri 25' ten büyüktür...");
            }
            else
            {
                Console.WriteLine("Karde değeri 25' ten küçüktür...");
            }

            Console.ReadLine();
        }

        static int kareal (int a)
        {
            return a * a;
        }

    }
}
