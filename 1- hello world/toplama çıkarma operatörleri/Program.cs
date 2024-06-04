using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama_çıkarma_operatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 289;
            int sayi2 = 921;
            int sayi3 = 891;
            int sayi4 = 1000;

            // parentez ile işlem önceliği veriliyor toplamaya.
            int sonuc = (sayi1 + sayi2 + sayi3)-sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine(); 
        }
    }
}
