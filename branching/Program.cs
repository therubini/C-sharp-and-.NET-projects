using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease enter package weight, please.");
            decimal weight = decimal.Parse(Console.ReadLine());                                              //weight


            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //weight to heavy to ship
            }
            else if (weight < 50)
            {
                Console.WriteLine("What is the pacakge width? ");                                           //width
                decimal width = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the pacakge height? ");                                          //height
                decimal height = decimal.Parse(Console.ReadLine());


                Console.WriteLine("What is the pacakge length? ");                                         //length
                decimal length = decimal.Parse(Console.ReadLine());

                decimal totalD = width + height + length;                                                 //total dimensions of pacakage 

                if (totalD > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");             //pacage to big to ship
                }

                else if (totalD < 50)
                {
                    decimal total = (totalD * weight) / 100;                                             //total price to shop pacage

                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + string.Format("{0:0.##}", total));
                    Console.WriteLine("\nThank you.");
                }
            }


            Console.ReadLine();

        }

    }
}
