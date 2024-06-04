using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsüller__GİRİŞ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geter seter metotları :

            test test1 = new test();

            test1.setisim("Bora");
            string gelenisim = test1.getisim();

            if(gelenisim == "Bora")
            {
                Console.WriteLine("Gelen isim Boradır.");
            }

            else
            {
                Console.WriteLine("Bune lo ?");
            }

            Console.ReadLine();
            

            
        }
    }
}
