using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays___kullanıcıdan_alınan_sayılar_ile_işlemler_yapma_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10];

            int tekadettoplam = 0;
            int ciftadettoplam = 0;

            int teksayilarintoplami = 0;
            int ciftsayilarintoplami = 0;

            int kullanicideger;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 0) + ".index değerini giriniz :");
                kullanicideger = int.Parse(Console.ReadLine());

                sayilar[i] = kullanicideger; // dizimin içini kullanıcıdan aldığım değerlerle doldurdum.
            }

            for(int j = 0; j<sayilar.Length; j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftadettoplam++;
                    ciftsayilarintoplami += sayilar[j];
                }

                else
                {
                    tekadettoplam++;
                    teksayilarintoplami += sayilar[j];
                }

            }

            if (ciftsayilarintoplami>teksayilarintoplami)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür");
                
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür");
            }


            Console.WriteLine("**************************************");

            Console.WriteLine("Çift sayıların toplamı :"+ ciftsayilarintoplami);
            Console.WriteLine("Çift sayıların adedi :"+ ciftadettoplam);

            Console.WriteLine("**********************************");

            Console.WriteLine("Tek sayıların toplamı :" + teksayilarintoplami);
            Console.WriteLine("Tek sayıların adedi :" + tekadettoplam);

            Console.ReadLine();
        }
    }
}
