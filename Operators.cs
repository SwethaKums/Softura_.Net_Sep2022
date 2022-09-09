using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Operators
    {
        
        public static void Main()
        {

            MulDiv mulDiv = new MulDiv();
            mulDiv.multiply(5, 7);
            mulDiv.divide(7, 9);
            AddSub addSub = new AddSub();
            addSub.add(8, 9);
            addSub.subtraction(9, 10);



        }
        public class AddSub
        {
            int n1, n2;
            public void add(int n1, int n2)
            {

                this.n1 = n1;
                this.n2 = n2;
                Console.WriteLine("The addition of two number is{0}",n1+n2);

            }

            public void subtraction(int n1, int n2)
            {

                this.n1 = n1;
                this.n2 = n2;
                Console.WriteLine("The sub of two number is {0}",n1-n2);

            }
        }
        public class MulDiv:AddSub

        {
            int n1, n2;
            public void multiply(int n1, int n2)
            {

                this.n1 = n1;
                this.n2 = n2;
                Console.WriteLine("The addition of multiplication number is  {0}",n1*n2);

            }

            public void divide(int n1, int n2)
            {

                this.n1 = n1;
                this.n2 = n2;
                Console.WriteLine("The divison of two number is {0}",n1/n2);

            }
            
        }
    }
}
