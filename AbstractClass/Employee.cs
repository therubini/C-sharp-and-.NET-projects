using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person, IQuitTable                                    //Inherit class from Person and Interface from IQuitTable
    {               
        public override void SayName()                                //Override to pull method from Person Class 
        {
            //Console.WriteLine("\n--Employee Name: ");              //Console custome
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
                Console.WriteLine("\nBest of Luck! " + lastName + "," + " security will escort you out.");
            }

        }
        public static bool operator ==(Employee person, Employee person2)       //Operator Overloading using the "==", comparing person's ID && person2's ID 
        {
            if (person.ID == person2.ID) 
            {
                return true;
            }
           return false;
        }

        public static bool operator !=(Employee person, Employee person2)
        {
            if (person.ID != person2.ID) 
            {
                return true;
            }
            return false;
        }
    }
}
