using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erişim_belirleyici__protected_
{
    public class Class2
    {
        private void privatemetot()
        {
            Console.WriteLine("Private metot çalıştı...");
        }

        protected void protectedmetot()
        {
            Console.WriteLine("Protected metot çalıştı...");
        }
    }
}
