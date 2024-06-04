using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance__ÖRNEK_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan uygulamasına Hoşgeldiniz....");

            Console.WriteLine("1- Yazılımcı işlemleri : ");
            Console.WriteLine("2- Yönetici işlemleri : ");
            Console.WriteLine("Çıkış için 3 e basın.");

            string secilenislem = Console.ReadLine();

            while(true)
            {
                if (secilenislem == "3")
                {
                    Console.WriteLine("Programdan çıkılıyor....");
                    break;
                }
                else if (secilenislem == "1")
                {
                    yazilimci yazilimci = new yazilimci (1, "Bora","Uysal");
                    Console.WriteLine("Yazılımcı işlemi seçiniz : ");
                    Console.WriteLine("1- Format at : ");
                    Console.WriteLine("2- Yazılımcı bilgilerini göster : ");
                    Console.WriteLine("Çıkış için 3 e basın.");
                    string yazilimciislem = Console.ReadLine();

                    while(true)
                    {
                        if(yazilimciislem == "3")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor....");
                            break;
                        }
                        else if (yazilimciislem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz :");
                            string isletimsistemi = Console.ReadLine();
                            yazilimci.formatat(isletimsistemi);
                            
                        }
                        else if(yazilimciislem == "2")
                        {
                            yazilimci.bilgilerigoster();
                            
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz...");
                            
                        }
                    }
                }

                else if(secilenislem == "2")
                {
                    yonetici yonetici = new yonetici(2, "Yakup", "Reçber", 12);

                    Console.WriteLine("Yönetici işlemi seçiniz : ");
                    Console.WriteLine("1- Zam yap : ");
                    Console.WriteLine("2- Yönetici bilgilerini göster :");
                    Console.WriteLine("3- Çıkış için 3 e basınız.");
                    string yoneticiislem = Console.ReadLine();

                    while(true)
                    {
                        if (yoneticiislem == "3")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkılıyor....");
                            break;
                        }


                        else if(yoneticiislem == "1")
                    {
                        Console.Write("Zam miktarını giriniz : ");
                            int zammiktari = Convert.ToInt32(Console.ReadLine());   
                            yonetici.zamyap(zammiktari);
                            

                    }

                        else if(yoneticiislem=="2")
                        {
                            yonetici.bilgilerigoster();
                            
                        }

                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz");
                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir işlem giriniz...");
                }

                }
            Console.ReadLine();


            }
    }
}
