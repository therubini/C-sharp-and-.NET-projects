using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                                             //Exercise # 156
            Console.WriteLine(DateTime.Now);                                                                          //Displaying current time

            Console.WriteLine("\nProvide a number to add in hours to the current time");
            int number = Convert.ToInt32(Console.ReadLine());                                                       

            DateTime futureTime = DateTime.Now.AddHours(number);                                                      //User input to apply to .AddHours

            Console.WriteLine("\nWhen you add {0} to the current time in hours, you get {1} ", number, futureTime);

            Console.ReadLine();
        }
    }
}
