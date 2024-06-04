using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__diğer_veri_tipleri_ile_dizi_tanımlama_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string
            // double
            // char

            string[] isimler = { "Bobo","Gamo","Gobo","Gambor" };

            for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.ReadLine();


        }
    }
}
