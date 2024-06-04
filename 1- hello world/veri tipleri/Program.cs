using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte = 0 - 255 arası sayılar.

            byte birinci = 5;
            byte ikinci = 25;
            byte ucuncu = 255;

            byte maxdeger = byte.MaxValue;
            byte mindeger = byte.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);

            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);

            Console.ReadLine();

        }
    }
}
