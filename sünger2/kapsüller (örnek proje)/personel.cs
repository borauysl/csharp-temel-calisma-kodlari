using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsüller__örnek_proje_
{
    public class personel
    {
        private string tckimlikno;

        public string TCKİMLİKNO
        {
            get
            {
                return tckimlikno.Substring(0, 5) + "******";
            }

            set
            {
                bool kontrol = false;

                if(value.Length==11)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                      bool sayim =    char.IsNumber(value[i]);

                        if(sayim)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                            
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Lütfen tc kimlik no içinde sayı kullanınız. ");
                    }
                    else
                    {
                        tckimlikno = value; 
                    }

                    
                }
                else
                {
                    Console.WriteLine("TC kimlik no 11 haneli olmak zorundadır....");
                }
                    
            }
        }

    }
}
