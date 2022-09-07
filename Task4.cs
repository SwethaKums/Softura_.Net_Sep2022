using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{ 
    internal class Task4
    {
        public static void Main()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=number && number<=20; i++)
                Console.WriteLine(("N"+"*"+i+"="+i+"N"));
        }
    }
}
