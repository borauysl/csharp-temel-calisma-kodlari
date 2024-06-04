using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays___for_each_döngüsü_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Bobo", "Gamo", "Gobo", "Gambor" };

            // 1. yol :

           /* for(int i = 0; i <isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }*/

            // 2. yol :

            foreach(string a in isimler)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
