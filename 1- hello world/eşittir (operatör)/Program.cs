using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşittir__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eşittir : ==

            //burada 4 = 5 e eşittir diyor ama eşit olmadığı için bool bize false verecektir fakat 4 = 4 olsaydı true verirdi.

            int sayi1 = 4;
            int sayi2 = 5;

            bool kontrolet = sayi1 == sayi2;

            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
