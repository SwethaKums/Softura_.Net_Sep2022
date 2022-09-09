using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Membership
    {
        public static void Main()
        {
Membership membership = new Membership();
            membership.userLogin("swetha", "swetha@31");
            membership.userLogin(001, 678);
            membership.userLogin(9789459874L, 897);
        }
        public void userLogin(String emailid,string password)
        {
            Console.WriteLine("the emailis is {0} and password is {1}",emailid,password);
        }
        public void userLogin(int memberid, int pin)
        {
            Console.WriteLine("the memberid is {0} and the pin number  is {1}",memberid,pin);
        }
        public void userLogin(long mobilenumber, int pin)
        {
            Console.WriteLine("the mobilenumber is {0} and the pin is {1}",mobilenumber,pin);
        }
    }
}
