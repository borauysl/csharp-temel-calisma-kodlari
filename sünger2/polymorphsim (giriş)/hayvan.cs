using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsim__giriş_
{
    public class hayvan
    {
        public string isim;

        public hayvan(string isim)
        {
            this.isim = isim;
        }
        public string getisim()
        { 
            return isim;
        }

        public void setisim(string isim)
        {
            this.isim =isim;
        }

        public virtual void konus() // virutal ile ezilebilir hale getiriyorum.
        {
            Console.WriteLine("Hayvan konuşuyor.");
        }

    }
}
