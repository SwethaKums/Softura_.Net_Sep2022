﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task6
    {
        public static void Main()
        {
            int[] array = {78,89,56,98,45};
           // Console.WriteLine("The total is {0}", array[0]+array[1]+array[2] +array[3]+array[4]);
            int total = array[0]+array[1]+array[2] +array[3]+array[4];
            Console.WriteLine("the total is {0}",total);
            int percentage=(total/5);
            Console.WriteLine("The percentage is {0}",percentage);




        }
    }
}