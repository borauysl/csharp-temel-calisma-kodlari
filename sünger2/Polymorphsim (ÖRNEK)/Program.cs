using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim__ÖRNEK_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz...");
            Console.WriteLine("*************************************");

            while(true)
            {
                Console.WriteLine("İşlem Seçiniz : ");
                Console.WriteLine("1- Dikdörtgen işlemleri :");
                Console.WriteLine("2- Üçgen işlemleri : ");
                Console.WriteLine("3- Kare işlemleri (üşendim yapmaya) : ");
                Console.WriteLine("4- Çıkış yap.");
                
                string secim = Console.ReadLine();

                if(secim=="4")
                {
                    break;
                }

                else if (secim=="1")
                    {
                    
                        while(true)
                        {
                        Console.WriteLine("1- Dikdörtgen alanı heasapla : ");
                        Console.WriteLine("2- Dikdörtgen bilgilerini göster : ");
                        Console.WriteLine("3- Çıkış yap.");

                        string secimdikdortgen = Console.ReadLine();

                        if(secimdikdortgen=="1")
                        {
                            Console.WriteLine("Kısa kenarı giriniz :");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun kenarı giriniz :");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());

                         dikdortgen dikdortgen = new dikdortgen("Dikdörtgen",kisakenar,uzunkenar);

                            dikdortgen.sekilhesapla();

                        }
                        else if(secimdikdortgen=="2")
                        {
                            Console.WriteLine("Kısa kenarı giriniz :");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun kenarı giriniz :");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());

                            dikdortgen dikdortgen = new dikdortgen("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilbilgilerigoster();
                        }
                        else if (secimdikdortgen=="3")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }
                      }
                    }

                else if(secim == "2")
                {
                    Console.WriteLine("1-  Üçgen alanı heasapla : ");
                    Console.WriteLine("2- Üçgen bilgilerini göster : ");
                    Console.WriteLine("3- Çıkış yap.");

                    string secimucgen = Console.ReadLine();

                    while(true)
                    {
                        if(secimucgen=="1")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz :");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz :");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            ucgen ucgen = new ucgen("Üçgen", tabanalani, yukseklik);

                            ucgen.sekilhesapla();
                        }

                        else if(secimucgen == "2")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz :");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz :");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            ucgen ucgen = new ucgen("Üçgen", tabanalani, yukseklik);

                            ucgen.sekilbilgilerigoster();

                        }
                        
                        else if(secim=="3")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Yapmadım işte amk :)");
                    Console.WriteLine("************************************************");
                }
              }

            

        }
    }
}
