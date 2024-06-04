using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veya__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veya operatörü : || 

            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;
            // veya (||) kullanıldığında işlemde ne kadar yanlış olursa olsun eğer işlem true içeriyorsa bool = true.
            bool kontrolet = sayi1 == sayi2 || sayi1 > sayi3;

            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
