using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_yapıcı_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kullanici k1 = new kullanici(1, "Bora","Uysal");

            k1.bilgilerigoster();
            k1.zamyap(700);

            Console.ReadLine();




        }
    }
}
