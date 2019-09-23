using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person, IQuitTable                                    //Inherit class from Person and Interface from IQuitTable
    {
        public override void SayName()                                //Override to pull method from Person Class along with console custom
        {
            Console.WriteLine("Employee Name:\n");
            base.SayName();
        }
        public void Quit(Employee employee)                          //Method to be called
        {
            Console.WriteLine("\nWould you like to quit?    yes or no");
            string bye = Console.ReadLine();

            if (bye == "no")
            {
                Console.WriteLine("\nGreat! You're getting a promotion of 1 billion dollars!!");
            }
            else
            {
                Console.WriteLine("\nBest of Luck! " + lastName +  " Security will escort you out.");
            }
        }
    }
}
