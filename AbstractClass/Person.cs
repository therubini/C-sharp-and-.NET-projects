using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person                                          //Abstract class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void SayName()                                     //Virtual keyword
        {
            Console.WriteLine( firstName + " " + lastName);
        }
    }
}
