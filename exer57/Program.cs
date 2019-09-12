using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report: \n");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What number are you on?");
            string number = Console.ReadLine();
            int currentNumber = Convert.ToInt32(number);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false\".");
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            ulong totalhours = Convert.ToUInt64(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
