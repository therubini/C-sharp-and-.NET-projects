using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            string p1rate = Console.ReadLine();
            decimal p1r = decimal.Parse(p1rate);         // person 1 hourly rate
            Console.WriteLine("Hours worked per week?");
            string p1worked = Console.ReadLine();
            decimal p1w = decimal.Parse(p1worked);       // person 1 hours worked in a week


            Console.WriteLine("\nPerson 2:");
            Console.WriteLine("Hourly Rate?");
            string p2rate = Console.ReadLine();
            decimal p2r = decimal.Parse(p2rate);         // person 2 hourly rate
            Console.WriteLine("Hours worked per week?");
            string p2worked = Console.ReadLine();
            decimal p2w = decimal.Parse(p2worked);       // person 2 hours worked in a week

            decimal p1total = p1r * p1w;

            Console.WriteLine("\nWeekly salary of Person 1: ");   // person 1 weekly total salary
            Console.WriteLine(p1total);

            decimal p2total = p2r * p2w;

            Console.WriteLine("\nWeekly salary of Person 2: ");     // person 2 weekly total salary
            Console.WriteLine(p2total);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?"); //boolian logic

            bool money = p1total > p2total;
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
