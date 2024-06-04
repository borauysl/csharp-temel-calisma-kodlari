using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class___öğrenci_uygulaması__
{
    public class ogrenci

    {
        private int ogrencino;

        private string isim;
        private string soyisim;

        private int vize1;
        private int vize2;

        private int final;

        private string okulismi;

        public ogrenci(int _ogrno, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrencino = _ogrno;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }




        public void ogrecibilgilerigoster()
        {
            Console.WriteLine("Öğrencinin Numarası :" + ogrencino);
            Console.WriteLine("Öğrencinin İsmi :" + isim);
            Console.WriteLine("Öğrencinin Soy ismi :"+soyisim);
            Console.WriteLine("Öğrenci Vize 1. :" + vize1);
            Console.WriteLine("Öğrenci Vize 2. :" + vize2);
            Console.WriteLine("Öğrenci Final :" + final);
            Console.WriteLine("Öğrencinin Okulu :"+okulismi);
        }

        public double ogrencinotubul()
        {
         double ortalama=vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

            return ortalama;
        }

        public void okulgetir()
        {
            Console.WriteLine("Öğrencinin Okulu :"+ okulismi);
        }



            
    }
}
