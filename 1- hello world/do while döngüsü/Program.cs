using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayıları ekrana yazdırınız (do while)
            //1 den 100 e kadar olan sayıların toplamını ekrana yazdırınız (do while)
            /*int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a <= 10);
            
            Console.ReadLine();*/

            int b = 1;
            int toplam = 0;

            do
            {
                toplam += b;
                b++;
            }
            while (b <= 100);
            Console.WriteLine("1 den 100 e kadar olan sayıların toplamı :" +toplam);

            Console.ReadLine();
        }
    }
}
