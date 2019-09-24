using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> emps = new Employee<string>();
            emps.things = new List<string>() {"Jonathan", "Mark", "Anthony",                   //Instantiated an Employee object with type "string"
                "Ben", "Mary", "Rachel",
                "Christy"};

            Employee<int> id = new Employee<int>();
            id.things = new List<int>() { 27, 258, 542, 25, 69, 255, 29, 45, 34, 33 };         //Instantiated an Employee object with type "int"

            var newList = emps.things.Zip(id.things, (s, i) => new { sv = s, iv = i }).ToList();   //Using Zip() to show different lenghts in the list and join accordingly

            foreach(var x in newList)
            {
                Console.WriteLine("{0}: {1}", x.sv, x.iv);
            }

            Console.ReadLine();
        }
    }
}
