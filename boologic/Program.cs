using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boologic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int dage = Convert.ToInt32(age);                     //age

            Console.WriteLine("\nHave you ever had a DUI?");
            string dui = Console.ReadLine();                     //dui boolean
            bool xdui = bool.Parse(dui);

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int tickets = Convert.ToInt32(ticket);               //tickets

            bool Result = (dage > 15 && xdui == false && tickets < 3); //boolean logic

            Console.WriteLine("\nQualified?");                        //results
            Console.WriteLine(Result);
            
            Console.ReadLine();
            
        }
    }
}
