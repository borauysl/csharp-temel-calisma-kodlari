using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_giriş_programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı giriş uygulaması yapacağız.
            // kullanıcı adını ve şifresini doğru yazarsa tebrikler giriş yaptınız.
            // yanlış girerse hata vereceğiz ve doğru şekilde girmesi için 3 hak tanıyalım yalnış girdiği sürece döngüye girmeye devam etsin.

            int hak_sayisi = 3;

            while(true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz :");
                string KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz :");
                string sifre = Console.ReadLine();

                if (KullaniciAdi == "bora" && sifre == "gamoyucokseviyom")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :");
                    break;
                }

            
            else
             
                Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");

                if (hak_sayisi>0)
                {
                    hak_sayisi -= 1;
                }
                if (hak_sayisi==0)
                {
                    Console.WriteLine("Hakkınız dolmuştur giriş yapamazsınız.");
                    break;
                }
             }
            Console.ReadLine();

        }
    }
}
