using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Package
    {

        public static void Main()
        {
            Silver benefits = new Silver();
            benefits.medal();
            benefits.accomodation();
            Gold gold = new Gold();
            gold.medal();
            gold.accomodation();
            gold.food();

            platinum pla = new platinum();
            pla.medal();
            pla.accomodation();
            pla.food();
        }

        class Silver : MembershipPack
        {
            public void medal()
            {
                Console.WriteLine("silvermedal");
            }
            public void accomodation()
            {
                Console.WriteLine("3 days accomodation at resort");
            }
        }
            class Gold : MembershipPack,Member
            {


                public void medal()
                {
                    Console.WriteLine("Gold medal");
                }
                public void accomodation()
                {
                    Console.WriteLine("5 days accomodation at resort");
                }
                public void food()
                {
                    Console.WriteLine("2 dinners on the house");
                }
            }

            class platinum : MembershipPack,Member

            {
                public void medal()
                {
                    Console.WriteLine("platinummedal");
                }
                public void accomodation()
                {
                    Console.WriteLine("7 days accomodation at resort");
                }
                public void food()
                {
                    Console.WriteLine("5 dinners on the house");
                }
            }

        }

    }

