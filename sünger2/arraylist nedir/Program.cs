using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* array ile uygulama :
             *
               string[] isimler = { "Bobo", "Gamo", "Gobo", "Gambor" };

               foreach (string a in isimler)
               {
                   Console.WriteLine(a);
               }
               Console.ReadLine*/

            // array list kullanımı ile :

            ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("Enes");
            koleksiyon.Add("Ali");
            koleksiyon.Add("Bora");
            koleksiyon.Add("Gamze");

            // kaldırır
            //koleksiyon.Remove("Ali");

            // arraydaki değerleri sayar
            //int count =  koleksiyon.Count;

            // arraydaki değerleri siler
            //koleksiyon.Clear();

            // array içindeki değerleri kontrol etmeye yarar
            //bool kontrol = koleksiyon.Contains("Bora");

            // hangi satırda olduğunu kontrol eder.
            //int index =  koleksiyon.IndexOf("Bora");

            // satırlar arasına değer ekler.
            //koleksiyon.Insert(3, "Gamo");

            //diziyi ters çevirir.
            //koleksiyon.Reverse();

            // int değerlerini küçükten büyüğe sıralar
            // rakamlar.Sort();



            foreach (var a in koleksiyon)
            {
                Console.WriteLine(a);
            }

            //Console.WriteLine("Dizinin eleman sayısı :"+ count);

            //Console.WriteLine("Var mı ? :"+kontrol);

            //Console.WriteLine("İndex Numarası :"+index);



            Console.ReadLine();


           
        }
    }
}
