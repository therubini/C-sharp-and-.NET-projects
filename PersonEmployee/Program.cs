using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    class Program
    {
                                                       //EXERCISE #120
        static void Main(string[] args)
        {
            Employee person = new Employee();         //Inherit from Person class 
            person.Firstname = "Sample";
            person.Lastname = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
