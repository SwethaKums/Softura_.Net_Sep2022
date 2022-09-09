using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task7
    {
        public static void Main()
        {
            string[][] lists = new string[3][];
            lists[0]=new string[] { "5050", "maska", "chaska", "oreo" };
            lists[1]=new string[] { "5star", "dairymilk", "munch", "lollypop", "candy" };
            lists[2]=new string[] { "coffee", "tea", "coke", "pepsi", "fanta", "milkshake" };
            for (int i = 0; i<lists.Length; i++)
            {
              
                for (int j = 0; j<lists[i].Length; j++)
                {
                    Console.Write(lists[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
