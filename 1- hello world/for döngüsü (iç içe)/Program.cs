﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü__iç_içe_
{
    internal class Program
    {
        static void Main(string[] args)
        { 

         for(int i = 1; i<=10; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();


        }
    }
}
