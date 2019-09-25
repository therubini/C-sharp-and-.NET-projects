using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Method
    {
        empList emplist = new empList();
        public List<Employee> jList = new List<Employee>();

        public void mOne()                                                 //Using 'foreach' loop to grab firstnames equal to Joe
        {
            Console.WriteLine("\nNames with Joe using a \'foreach\' loop.");

            foreach (Employee employee in emplist.employees)
            {
                if(employee.firsName == "Joe")
                {
                    jList = new List<Employee>();
                    jList.Add(employee);
                    Console.WriteLine("\n\tEmployee ID: " + employee.ID + " Employee: " + employee.firsName + " " + employee.lastName);
                }
            }
        }
        public void mTwo()                                                //Lambda to grab firstnames equal to Joe
        {
            empList emplist = new empList();

            Console.WriteLine("\nNames with Joe using \'Lambda\'.");
            List<Employee> lambda = emplist.employees.Where(x => x.firsName == "Joe").ToList();
            foreach(Employee employee in lambda)
            {
                Console.WriteLine("\n\tEmployee ID: " + employee.ID + " Employee: " + employee.firsName + " " + employee.lastName);
            }

        }
        public void mThree()                                              //Lambda to grab names with ID's greater than 5
        {
            empList emplist = new empList();

            Console.WriteLine("\nNames with ID's greater than 5 using \'Lambda\'.");
            List<Employee> Lid = emplist.employees.Where(x => x.ID > 5).ToList();
            foreach(Employee employee in Lid)
            {
                Console.WriteLine("\n\tEmployee ID: " + employee.ID + " Employee: " + employee.firsName + " " + employee.lastName);

            }
        }
        public void mFour()
        {
            empList emplist = new empList();

            List<Employee> employees = emplist.employees;

            foreach(Employee employee in employees )
            {
                Console.WriteLine("\n\tEmployee ID: " + employee.ID + " Employee: " + employee.firsName + " " + employee.lastName);

            }
        }

    }
}
