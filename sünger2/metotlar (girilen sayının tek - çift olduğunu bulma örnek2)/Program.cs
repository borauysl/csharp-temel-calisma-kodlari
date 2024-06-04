using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar__girilen_sayının_tek___çift_olduğunu_bulma_örnek2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir sayı giriniz :");

            int girilensayi = int.Parse(Console.ReadLine());

            tekmiciftmi(girilensayi);

            Console.ReadLine();
        }

        static void tekmiciftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir...");
            }
            else
            {
                Console.WriteLine("Sayı tektir...");
            }
        }

            
    }
}
