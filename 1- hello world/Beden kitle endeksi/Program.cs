using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_kitle_endeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle endexi = kilo / boy*boy
            // Beden kitle endexi 18' e eşit veya düşükse ZAYIF
            //18 ile 25 arasındaysa NORMAL
            // 25' ten büyükse OBEZ yazdıran program parçasını kodlayınız.

            Console.WriteLine("Lütfen Kilonuzu Giriniz :");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("ZAYIF");
            }

            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("NORMAL");
            }

            else if (bke >25)
            {
                Console.WriteLine("OBEZ");
            }
            Console.ReadLine();
        }
    }
}
