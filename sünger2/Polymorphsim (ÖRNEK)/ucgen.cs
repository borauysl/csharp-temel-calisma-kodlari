using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim__ÖRNEK_
{
    public class ucgen : sekil
    {
        public int tabanalani { get; set; }
        public int yukseklik { get; set; }

        public ucgen(string isim, int tabanalani, int yukseklik) : base(isim)
        {
            this.tabanalani = tabanalani;
            this.yukseklik = yukseklik;
        }

        public override void sekilhesapla()
        {
            base.sekilhesapla();
            Console.WriteLine(getisim()+" nin alanı"+(tabanalani*yukseklik)/2);
        }

        public override void sekilbilgilerigoster()
        {
            base.sekilbilgilerigoster();

            Console.WriteLine(getisim() + "Şeklin ismi :  : " + this.getisim());
            Console.WriteLine(getisim() + "nin taban alanı : " + this.tabanalani);
            Console.WriteLine(getisim() + "nin yüksekliği : " + this.yukseklik);
        }

    }
}
