using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyon.Entity
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapyazar { get; set; }

        public string kitapdili { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyil { get; set; }

        public Kitap()
        {

        }

        public Kitap(int kitapid, string kitapisim, string kitapyazar, string kitapdili, string yayinevi, string tur, int adet, int sayfasayisi, int basimyil)
        {
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyil = basimyil;
        }

        public int getkitapid()
        {
            return this.kitapid;
        }

        public string getkitapisim()
        {
            return this.kitapisim;
        }

        public string getkitapyazar()
        {
            return this.kitapyazar;
        }

        public string getkitapdili()
        {
            return this.kitapdili;
        }

        public string getyayinevi()
        {
            return this.yayinevi;
        }

        public string gettur()
        {
            return this.tur;
        }

        public int getadet()
        {
            return this.adet;
        }

        public int getsayfasayisi()
        {
            return this.sayfasayisi;
        }

        public int getbasimyili()
        {
            return this.basimyil;
        }

    }
    
}
