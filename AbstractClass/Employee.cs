using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee: Person                                    //Inherit class from Person
    {
        public override void SayName()                                //Override to pull method from Person Class along with console custom
        {
            Console.WriteLine("Employee Name:\n");
            base.SayName();
        }
    }
}
