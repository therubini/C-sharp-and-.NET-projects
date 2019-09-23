using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {                                                                     //EXERCISE # 124 and #126
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.SayName();                                             //Method called from Employee
            person.Quit(employee: person);                                //Method called from Employee Interface of IQuitTable
            Console.ReadLine();
        }

    }
}
