﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task2
    {
        public static void Main()
        {
            Console.WriteLine("Do you have travel history");
            {
                if (Console.ReadLine()=="Yes")
                    Console.WriteLine("Do you have temperature");

                else
                    Console.WriteLine("safe");
            }
            {
                if (Console.ReadLine()=="Yes")
                    Console.WriteLine("DO you have cough and sneeze");

                else
                    Console.WriteLine("safe");
            }
            {
                if (Console.ReadLine()=="Yes")
                    Console.WriteLine("Swap test");
                else
                    Console.WriteLine("Quaratine fever mediacation");

            }
        }
    }
}









