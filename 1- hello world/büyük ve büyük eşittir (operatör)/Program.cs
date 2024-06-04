using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büyük_ve_büyük_eşittir__operatör_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* büyüktür operatörü >
            // büyük eşittir operatörü >=
            // 18 18 den büyük değildir fakat eşit olduğu için bool = ture.
             küçüktürde de aynı kurallar geçerlidir.*/
            int yas = 18;

            bool kontrolet = yas >= 18;

            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
