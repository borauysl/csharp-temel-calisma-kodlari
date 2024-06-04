using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___giriş_
{
    public class Araba
    {
        public int kapi_sayisi;
        public string araba_model;

        public string araba_rengi;

        public Araba()
        {
            Console.WriteLine("Araba sınıfının yapıcı metodu çalıştı...");
        }

        public void motorcalistir()
        {
            Console.WriteLine("Motor Çalışıyor....");
        }

        public void kapilarikilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor....");
        }
        
    }
}
