using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim__ÖRNEK_
{
    public class dikdortgen : sekil 
    {

        public int kisakenar { get; set; }
        public int uzunkenar { get; set; }



        public dikdortgen(string isim, int kisakenar, int uzunkenar) : base (isim)
        {

            this.kisakenar = kisakenar;
            this.uzunkenar = uzunkenar;
        }

        public override void sekilhesapla()
        {
            base.sekilhesapla();
            Console.WriteLine(getisim()+" nin alanı : "+(kisakenar*uzunkenar));
        }

        public override void sekilbilgilerigoster()
        {
            base.sekilbilgilerigoster();

            Console.WriteLine(getisim() + "Şeklin ismi :  : " + this.getisim());
            Console.WriteLine(getisim()+ "nin kısa kenarı : "+this.kisakenar);
            Console.WriteLine(getisim() + "nin uzun kenarı : " + this.uzunkenar);
        }

    }
}
