using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_metot_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* static olmadann class kullanımı :
             * 
            personel p1 = new personel();
            p1.isimsoyisimyazdir();*/

            //static ile kullanımı :

            personel.isimsoyisimyazdir();

            personel.sayilaritopla(5,10);

            Console.ReadLine();

        }
    }
}
