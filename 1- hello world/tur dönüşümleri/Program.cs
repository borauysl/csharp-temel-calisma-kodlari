using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tur_dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stringler kelime metinidir sayı toplamı yapamaz.

            //burada string veri tipinden inte geçiş yaptık.
            string sayi1 = "2";
            string sayi2 = "3";
           

            //burada string metinlerini int metinine çeviriyoruz. (parse)
            int a = int.Parse(sayi1);
            int b = int.Parse(sayi2);

            /*aynı şekilde string metinlerini inte çeviriyoruz (convert + int32)
            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);*/

            //burada inti a ve b olarak atadığımız için a+b kullanıyoruz ve sonuç 5 çıkıyor.
            Console.WriteLine(a+b);
            


            //burada int veri tipinden string veri tipine geçiş yaptık.

            int sayi3 = 2;
            int sayi4 = 3;

           
            string c = sayi1.ToString();
            string d = sayi2.ToString();
            //stringler toplanamayacağı için 2 ve 3 ü yan yana yazar ve sonuç 23 çıkar.
            Console.WriteLine(c+d);


            //....KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR....

            Console.WriteLine("lütfen yaşınızı giriniz");
            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);


            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);

            Console.ReadLine();


        }
    }
}
