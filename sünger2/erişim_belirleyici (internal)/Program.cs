using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1;

namespace erişim_belirleyici__internal_
{
     class Program
    {
        static void test(string[] args)
        {

            // internal sadece bulunduğu proje içinden erişilebilen bir metottur.


            musteri musteri1 = new musteri();


            musteri1.publicmetot();

            Console.ReadLine();




        }
    }
}


