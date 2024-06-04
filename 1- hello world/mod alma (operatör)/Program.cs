using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_alma__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mod alma operatörü : % = sayıyı böler 10/3 = 9. 10 - 9 = 1 (bölümden kalan sayı.)

            int sayi1 = 10;
            int sayi2 = 3;

            Console.WriteLine(sayi1%sayi2);
            Console.ReadLine(); 
        }
    }
}
