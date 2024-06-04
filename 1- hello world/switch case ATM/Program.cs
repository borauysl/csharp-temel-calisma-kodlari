using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıya nasıl bir işlem yapmak istediğini soracağız (switch case)
            //1- bakiye görüntüleme
            //2- para çekme
            //3- para yatırma
            // 4- çıkış yap
            // 1 - 2 - 3 - 4 dışındaki bir değere hata ver.

            int bakiye = 850;

            Console.WriteLine("ATM' ye hoşgeldiniz.");

            Console.WriteLine("Lütfen bir işlem seçiniz.");

            Console.WriteLine("1- Bakiye görüntüle :");
            Console.WriteLine("2- Para çek :");
            Console.WriteLine("3- Para yatır :");
            Console.WriteLine("4- Çıkış yap :");
            
            string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :"+bakiye);
                    Console.ReadLine();
                    break;

                    case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                    if(cekilecek_tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz :"+ (bakiye-cekilecek_tutar));
                    }
                    Console.ReadLine();
                    break;

                   case "3":

                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni bakiyeniz :"+ (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;

                    case "4":
                    Console.WriteLine("Hesabınızdan çıkış yapılıyor İyi günler...");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz :");
                    Console.ReadLine();
                    break;

                    


            }
            
                

            
             

            

                
                
        }
    }
}
