using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Arithmet
    {
        abstract class arithmetic
        {
            public abstract void add(int x,int y);

            public abstract void subtract(int x,int y);
            public abstract void multiply(int x,int y);

            public abstract void divide(int x,int y);

        }

        class Calculation : arithmetic
        {
            
            public override void add(int x,int y)

            {
                
                Console.WriteLine("the add of two number is {0}",x+y);
            }
            public override void subtract(int x, int y)

            {
               
                Console.WriteLine("the sub of two number is {0}",x-y);
            }
            public override void multiply(int x, int y)

            {
              
                Console.WriteLine("the multiply of two number is {0}",x*y);
            }
            public override void divide(int x, int y)

            {
               
                Console.WriteLine("the division of two number is {0}",x/y);
            }

        }
        public static void Main()
        {
            Calculation calculation = new Calculation();
            calculation.add(5,8);
            calculation.subtract(7,3);
            calculation.multiply(5,8);
            calculation.divide(10,5);

        }
    }
}
