using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosul_yapisi__if_else__örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan uygulama yapınız.
            // eğer 100 - 80 arası ise A+
            //80 - 60 A
            //60 - 40 B+
            // 40 dan küçükse F yazdıran örneğin kod parçalarını yazdırın.

            Console.WriteLine("Lütfen 1. notunuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            
                Console.WriteLine("Not değeriniz A+");
            
            else if (sonuc > 60 && sonuc < 80)
                Console.WriteLine("Not değeriniz A");

            else if (sonuc > 40 && sonuc < 60)
                Console.WriteLine("Not değeriniz B+");

            else
                Console.WriteLine("Not değeriniz F");
            

        }
    }
}
