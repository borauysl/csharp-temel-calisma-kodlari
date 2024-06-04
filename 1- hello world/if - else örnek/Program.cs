using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if___else_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //öğrencinin notu 50 den fazlaysa başarılı az ise başarısız sayan program çıktısı koldayınız.

            int not = 30;
            //eğer koşul sağlanırsa if komutu uygulanır.
            if (not > 50)
                Console.WriteLine("öğrenci bu dersten başarılı şekilde geçmiştir.");

     
            //eğer koşul sağlanamazsa else komutuna atlanır.
            else
                Console.WriteLine("öğrenci bu derste başarısız olmuştur.");

            Console.ReadLine();


        }
    }
}
