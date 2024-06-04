using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsim__giriş_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hayvan hayvan = new hayvan("Hayvan");
            hayvan.konus();

            kedi kedi = new kedi("Kedi : ");
            kedi.konus();

            Console.ReadLine();

        }
    }
}
