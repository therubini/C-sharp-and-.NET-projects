using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class empList
    {
        public empList()
        {
                                                                        //Creating our lists with values
            employees = new List<Employee>();
            FName = new List<string>() { "Jonathan", "Christy", "Rachel", "Joe", "Abriella", "Addison", "Ammon", "Joe", "Mora", "Joe"};
            LName = new List<string>() { "Rubini", "Tyrell", "Nicole", "Trader", "Rubini", "Rubini", "Rubini", "Jack", "Clark", "Joe" };
            Id = new List<int>() { 6, 4, 1, 3, 7, 9, 10, 2, 11, 5
            };

            for (int i = 0; i < 10; i++)                                //Attaching values to a new list
            {
                Employee employee = new Employee();
                employee.firsName = FName[i];
                employee.lastName = LName[i];
                employee.ID = Id[i];
                employees.Add(employee);
            }
        }                                                               //Properties for our lists with values
        public List<string> FName { get; set; }      
        public List<string> LName { get; set; }
        public List<int> Id { get; set; }
        public List<Employee> employees { get; set; }                  //List created with all employee's info
    }
}

