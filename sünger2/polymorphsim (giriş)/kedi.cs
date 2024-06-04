using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsim__giriş_
{
    public class kedi : hayvan
    {
        public kedi(string isim) : base(isim)
        {

        }
        public override void konus() // override ile eziyorum.
        {
            Console.WriteLine(getisim()+"Miyavlıyor...");
        }

    }
}
