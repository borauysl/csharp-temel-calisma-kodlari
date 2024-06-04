using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_yapıcı_metot
{
    public class kullanici
    {

        // prop komutu :
        private int kullaniciid { get; set; }

        private  string isim { get; set; }

        private string soyisim { get; set; }

        private static int maas { get; set; }

        static kullanici()
        {
            maas = 2500;

        }


        // ctor komutu :
        public kullanici(int kullaniciid, string isim, string soyisim+)
        {

            kullaniciid = kullaniciid;
                isim = isim;
            soyisim = soyisim;



        }

        public void bilgilerigoster()
        {

            Console.WriteLine("Kullanıcı Bilgileri :");
            Console.WriteLine("id :"+ kullaniciid);
            Console.WriteLine("İsim :"+isim);
            Console.WriteLine("Soyisim :"+soyisim);
            Console.WriteLine("Maaş :"+maas);
        }

        public void zamyap(int zammiktari)
        {

            Console.WriteLine("Kullanıcıya zam yapılıyor....");
            Console.WriteLine("Şuanki maaşı :"+(maas+zammiktari));

        }


    }
}
