using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___öğrenci_uygulaması__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 - öğrenci bilgilerini göster
             * 2 - öğrenci ortalamasını göster
             * 3 - öğrenci okulunu göster
             * 4 - çıkış yap*/

            bool kontrol = true;

            ogrenci ogrenci1 = new ogrenci(1, "Bora", "Uysal", 50, 40, 73, " Aydın üniversitesi ");

            Console.WriteLine("Uygılamamıza Hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz : ");
            Console.WriteLine("**************************************************************");

   
            

            while(kontrol)
            {

                islemlerigoster();
                kare1();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                    
                        ogrenci1.ogrecibilgilerigoster();
                    break;

                        case "2":
                        double ogrenciortalama = ogrenci1.ogrencinotubul();
                        Console.WriteLine("Öğrencinin ortalaması :"+ogrenciortalama);
                        break;

                      case "3":
                        ogrenci1.okulgetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;
                        

            }
                kare2();

                }


            }
             static void islemlerigoster()
        {
            Console.WriteLine("1-) Öğrenci Bilgilerini Göster :");
            Console.WriteLine("2-) Öğrenci Ortalamasını Göster :");
            Console.WriteLine("3-) Öğrenci Okulunu Göster :");
            Console.WriteLine("4-) Çıkış Yap :");
        }

        static void kare1()
        {
            Console.WriteLine("**************************************************************");
        }

        static void kare2()
        {
            Console.WriteLine("**************************************************************");
        }
    }
}
