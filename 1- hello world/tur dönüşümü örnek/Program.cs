using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tur_dönüşümü_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran program yazınız.

            Console.WriteLine("birinci sayıyı giriniz");
            string sayi1 = Console.ReadLine();

            int a = Convert.ToInt32(sayi1);

            Console.WriteLine("ikinci sayıyı giriniz");
            string sayi2 = Console.ReadLine();
         
            int b = Convert.ToInt32(sayi2);

            // a ve b toplamını paranteze almazsan hata verir ve çalışmaz.
            Console.WriteLine("iki sayinin toplamı :"+(a+b));
            Console.ReadLine();
                
        
        
        }    

         


    }
}
