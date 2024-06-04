using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar___parametreli_metot_kullanımı_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parametrelere değer veriyoruz.
            toplamayap(5,7);
            carpmayap(4, 8);
            
            //isimleri tırnak içinde yazıyoruz çünkü string değeri taşıyorlar.
            isimyazdir("bora","uysal");

            Console.ReadLine();
        }
        // parantez içine parametreleri giriyoruz :
        static void toplamayap(int sayi1 ,int sayi2)
        {
            Console.WriteLine("Gönderilen sayıların toplamı :"+(sayi1 + sayi2));
        }

        static void carpmayap (int sayi1, int sayi2)
        {
            Console.WriteLine("Gönderilen sayıların çarpımı :"+(sayi1 * sayi2));
        }
        
        static void isimyazdir(string isim, string soyisim)
        {
            Console.WriteLine("İsim ve Soyisim :"+isim+ " " +soyisim);
        }
    }
}
