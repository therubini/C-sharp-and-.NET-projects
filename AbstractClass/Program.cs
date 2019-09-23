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
            Employee person = new Employee() { firstName = "Jonathan", lastName = "The Great", ID = 2727 }; 

            person.SayName();                                             //Method called from Employee
            person.Quit(employee: person);                                //Method called from Employee Interface of IQuitTable

            Employee person2 = new Employee() { firstName = "Ammon", lastName = "Awesome", ID = 2727 };
            person2.SayName();
            person2.Quit(person2);

            Console.Write("\n" + person2.firstName + " and " + person.firstName + " share the same ID's? ");
            Console.WriteLine(person == person2);                         //Bool Operator 

            Console.ReadLine();

        }

    }
}
