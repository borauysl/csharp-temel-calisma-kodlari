using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___giriş_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();

            araba1.kapi_sayisi = 4;
            araba1.araba_rengi = "kırmızı";
            araba1.araba_model = "Renault";

            araba1.kapilarikilitle();
            araba1.motorcalistir();

            Console.WriteLine("Arabanın kapı sayısı :" + araba1.kapi_sayisi);
            Console.WriteLine("Araba rengi :"+araba1.araba_rengi);
            Console.WriteLine("Arabanın modeli :"+ araba1.araba_model);

            Console.ReadLine();
        
        }
    }
}
