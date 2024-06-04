using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance__ÖRNEK_
{
    public class calisan
    {
        private int id;
        private string isim;
        private string soyisim;
    

    public calisan(int id, string isim, string soyisim)
    {
        this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
    }

        public int getid()
        {
            return this.id;
        }
        
        public void setid(int id)
        {
            this.id = id;
        }

        public string getisim()
        {
            return this.isim;
        }

        public void setisim(string isim)
        {
            this.isim = isim;
        }

        public string getsoyisim()
        {
            return this.soyisim;
        }

        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public void bilgilerigoster()
        {
            Console.WriteLine("İd : "+this.id);
            Console.WriteLine("İsim : "+this.isim);
            Console.WriteLine("Soyisim : "+this.soyisim);
        }

    }
}
