using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_değer_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("kullanıcının soy ismini giriniz");
            string soyisim = Console.ReadLine();



            Console.WriteLine("kullanıcının ismi :"  + isim);
            Console.WriteLine("kullanıcının soyismi :" + soyisim);
            Console.WriteLine("kullanıcının tam adı :" + isim + soyisim);

            Console.ReadLine(); 


        }
    }
}
