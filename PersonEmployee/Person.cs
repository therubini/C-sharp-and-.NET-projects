using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    public class Person
    {
        public string FirstName = "Unknown";
        public string LastName = "Unknown";
        public string Firstname { get; set; }
    
        public string Lastname { get; set; }
        public void SayName()
        {
             Console.WriteLine("Name: " + Firstname + " " + Lastname);
        }
    }
}
