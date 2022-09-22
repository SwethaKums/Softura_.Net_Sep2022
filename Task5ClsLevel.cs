using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Task5ClsLevel
    {

    public string Name { get; set; }
        public int Age { get; set; }

        public void Display(string Name, int Age)
        {
            Console.WriteLine("{0} is {1} years old", Name, Age);
        }
        public static void Main()
        {
            Task5ClsLevel obj = new Task5ClsLevel()
            {
                Age = 12,
                Name = "arjun"
            };
            Console.WriteLine("{0} is {1} years old", obj.Name, obj.Age);
            obj.Display("arjun", 12);
        }
    }

}
