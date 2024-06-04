using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar__girilen_2_sayının_büyük_olanını_bulma_örnek3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz :");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz :");
            int sayi2 = int.Parse(Console.ReadLine());

            kontrolet(sayi1, sayi2);

            Console.ReadLine();

        }

        static void kontrolet(int a, int b)
        {
            if(a>b)
            {
                Console.WriteLine("1 Sayı 2. Sayıdan büyüktür...");
            }

            else if (a==b)
            {
                Console.WriteLine("İki sayı da birbirine eşittir...");
            }

            else
            {
                Console.WriteLine("2 Sayı 1. Sayıdan büyüktür...");
            }
        }
    }
}
