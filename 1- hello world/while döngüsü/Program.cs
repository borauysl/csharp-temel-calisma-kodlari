using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayıları ekrana yazdırın.

            // 100 den 0 a kadar olan sayıların çift olanlarını büyükten küçüğüe yazdırın.

            /*int a = 1;

            while(a<=10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine(); 
            */

            int b = 100;
            
            while(b>=0)
            {
                Console.WriteLine(b);
                b = b - 2;
            }
            Console.ReadLine();
        }
    }
}
