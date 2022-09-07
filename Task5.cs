using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task5
    {
        public static void Main()
        {
            Console.WriteLine("enter the package");
            String package= Console.ReadLine();
            String[] packageA = { "South special ", "Childrrens club", "Movies" };
            for(int i = 0; i<packageA.Length; i++)
            {
                Console.WriteLine(packageA[i]);
            }

            String[] packageB = { "News ","sports", "Movies" ,"Regional2"};
            for (int i = 0; i<packageB.Length; i++)
            {
                Console.WriteLine(packageB[i]);
            }
            String[] packageC = { "Dicovery","history","national" };
            for (int i = 0; i<packageC.Length; i++)
            {
                Console.WriteLine(packageC[i]);
            }
            switch(package)
            {
                case "packageA":Console.WriteLine("the amount is{0}", 250);
                    break;
                case "packageB":Console.WriteLine("the amount is{0}", 450);
                    break; 
                case "packageC":Console.WriteLine("the amount is{0}", 350);
                    break;
                default:Console.WriteLine("Enter the correct package");
                    break;

                    
            }

            
        }
    }
}
