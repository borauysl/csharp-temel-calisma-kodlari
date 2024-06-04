using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__public___private_erişim_belirleyicileri_
{
    public class musteri
    {
        public string isim;

        public string soyisim;

        public int maasdegeri;

        public string cinsiyet;

        private int yas;

        

        public musteri()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı....");
            
        }

        public void musteribilgilerigoster()
        {
            Console.WriteLine("İsmi :"+isim);
            Console.WriteLine("Soyisim :"+ soyisim);
            Console.WriteLine("Maaş değeri :"+maasdegeri);
            Console.WriteLine("Cinsiyet :"+cinsiyet);
            Console.WriteLine("Yaş değeri :"+yas);
            
        }

        private void isimsoyisimyazdir(string musteriisim, string musterisoyisim)
        {
            Console.WriteLine("Müşterinin isimi ve Soyisimi :"+ musteriisim+""+musterisoyisim);
        }

    }
}
