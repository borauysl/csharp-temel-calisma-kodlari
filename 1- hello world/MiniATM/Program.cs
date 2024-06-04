using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıya nasıl bir işlem yapmak istediğini soracağız
            //1- bakiye görüntüleme
            //2- para çekme
            //3- para yatırma
            //q ya basarsa çıkış yapma

            int bakiye = 1000;

            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();

            if(secim=="1")
            {
                Console.WriteLine("Şuanki Bakiyeiz :"+bakiye);
                

            }
            else if (secim=="2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan Tutar :" +(bakiye-cekilecek_tutar));
                
                if (cekilecek_tutar<=bakiye)
                {
                    Console.WriteLine("Kalan Tutar : " + (bakiye-cekilecek_tutar));
                    
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla tutar çekemezsiniz");
                    
                }
            }
            else if (secim=="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar));
                
            }
            else if (secim=="q")
            {
                Console.WriteLine("ATM den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı İyi Günler... ");
               
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                
            }
            Console.ReadLine();
           

        }
    }
}
