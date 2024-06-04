using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsüller__örnek_proje_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            personel p1 = new personel();
                
                p1.TCKİMLİKNO = "23565988956";

            Console.WriteLine("TC kimlik numaranız :"+p1.TCKİMLİKNO);
            Console.ReadLine();

        }
    }
}
