using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathoperations
{
    class Program
    {
        static void Main(string[] args)
        {   //multiplication 

            Console.WriteLine("Please enter an amount to be mulitplied by 50.");
            string amount = Console.ReadLine();
            int multAmount = Convert.ToInt32(amount);
            int total = multAmount * 50;
            Console.WriteLine("Your answer is " + total);

            ////addition

            Console.WriteLine("Please enter an amount to be added by 25.");
            string add = Console.ReadLine();
            int addAmount = Convert.ToInt32(add);
            int sum = addAmount + 25;
            Console.WriteLine("Your answer is " + sum);

            ////division

            Console.WriteLine("Please enter an amount to be divided by 12.5.");
            string divid = Console.ReadLine();
            double divAmount = Convert.ToDouble(divid);
            double div = divAmount / 12.5;
            Console.WriteLine("Your answer is " + div);

            ////boolean logic

            Console.WriteLine("Please enter an amount, and I'll check to see if it is greater than 50.");
            string boo = Console.ReadLine();
            int booAmount = Convert.ToInt32(boo);
            bool compare = booAmount > 50;
            Console.WriteLine("Your answer is " + compare);

            //modulus operator

            Console.WriteLine("Please enter an amount to divide by 7 and I'll figure out the remainder");
            string rem = Console.ReadLine();
            decimal remAmount = decimal.Parse(rem);
            decimal remainder = remAmount % 7;
            Console.WriteLine("Your answer is " + remainder);
            Console.ReadLine();

        }
    }
}
