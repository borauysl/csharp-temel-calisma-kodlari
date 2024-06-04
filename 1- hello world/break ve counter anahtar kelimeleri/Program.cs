using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_ve_counter_anahtar_kelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //break anahtar kelimesi
            // counter anahtar kelimesi

            for(int a =1; a<=10; a++)
            {
             if(a==7)
                {
                    continue; // eğer contiune kullanırsak 10 a kadar devam eder.
                    //break; eğer break kullanırsak 7 de kırar.
                }
                Console.WriteLine("a nın değeri :"+a);
            }
            Console.ReadLine();
        }
    }
}
