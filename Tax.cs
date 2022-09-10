using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Tax
    {
        public static void Main()
        {
            Vat vat = new Vat();
            vat.vatCalculation(500);
            Gst gst = new Gst();
            gst.vatCalculation(500);
        }

        class Vat
        {
            public void vatCalculation(int amount)
            {

                Console.WriteLine("the vat is{0}", (amount*0.12));

            }
        }
            class Gst : Vat
            {
                public new void vatCalculation(int amount)
                {

                    Console.WriteLine("the gst is{0}", (amount*0.20));
                }
            }
        }
    }

