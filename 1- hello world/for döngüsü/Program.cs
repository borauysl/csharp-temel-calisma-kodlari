using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 1000 e kadar olan sayıları ekrana alt alta yazdırınız.
            // 1 den 1000 e kadar olan çift sayıları ekrana yazdırınız.

           /* for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
           */

            for(int a = 0; a<=1000; a=a+2)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
