using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mantığı___classlar_arası_
{
    public class kedi  :köpek
    {
        public void sescikar()
        {
            Console.WriteLine("Kedi ses çıkarıyor...");
        }

        public void hayvanbilgilerigoster()
        {
            Console.WriteLine("Hayvan ismi :"+isim);
            Console.WriteLine("Hayvan rengi :"+renk);
            Console.WriteLine("Hayvan kilo :"+kilo);
            Console.WriteLine("Hayvan ayak sayısı :"+ayaksayisi);
            Console.WriteLine("Hayvan Cinsiyet :"+cinsiyet);
        }
    }
}




