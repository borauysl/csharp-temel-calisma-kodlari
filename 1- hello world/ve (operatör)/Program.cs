using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ve__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ve operatörü : && işleme aralık koyar (ve)

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            //burdaki işlem full doğru olduğu için bool = true.
            bool kontrolet = sayi1 == sayi2 && sayi1 < sayi3;

            Console.WriteLine(kontrolet);
            Console.ReadLine();
               
        }
    }
}
