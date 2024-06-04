using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance__ÖRNEK_
{
    public class yazilimci : calisan
    {
        private string diller;
        public yazilimci(int id, string isim, string soyisim) : base(id, isim, soyisim)
        {
            this.diller = diller;
        }

        public void formatat(string isletim_sistemi)
        {
            Console.WriteLine(getisim()+"şuanda"+ ""+ isletim_sistemi+"işletim sistemine format atıyor..." );
        }
    }
}
