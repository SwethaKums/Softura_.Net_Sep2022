﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task3cs
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name");
            String name= Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=age; i++)
                Console.WriteLine(name);
        }
    }
}
