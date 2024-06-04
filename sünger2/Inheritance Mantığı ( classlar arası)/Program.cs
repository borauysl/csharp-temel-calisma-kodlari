using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mantığı___classlar_arası_
{
     class Program
    {
        static void Main(string[] args)
        {
            kedi kedi = new kedi();
            kedi.isim = "Boncuk";
            kedi.kilo = "3";
            kedi.renk = "Gri";
            kedi.cinsiyet = "Dişi";
            kedi.ayaksayisi = 4;

            kedi.sescikar();
            kedi.hayvanbilgilerigoster();

            Console.ReadLine();


        }
    }
}
