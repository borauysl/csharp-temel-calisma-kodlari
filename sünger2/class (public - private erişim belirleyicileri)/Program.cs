using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__public___private_erişim_belirleyicileri_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public -- private 

            // publice atananlar her yerden erişebilir.
            // private olarak atananlar sadece o class sayfasından erişilebilir.
            // müşteri classındaki private olan yaşa erişememiz buna örnektir.

            musteri musteri1 = new musteri();

            musteri1.isim = "Bora";
            musteri1.soyisim = "Uysal";
            musteri1.maasdegeri = 2500;
            musteri1.cinsiyet = "Erkek";

            musteri1.musteribilgilerigoster();

            Console.ReadLine();
                

        }
    }
}
