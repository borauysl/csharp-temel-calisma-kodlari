using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşit_değildir__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eşit değildir operatörü = !=

            // 3 = 4 eşit olmadığı için ve operatörümüz eşit değildir olduğu için bool : true.

            int sayi1 = 3;
            int sayi2 = 4;

            bool kontrolet = sayi1 != sayi2;

            Console.WriteLine(kontrolet);
            Console.ReadLine();

               
        }
    }
}
