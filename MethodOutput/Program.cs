using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOutput
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                                   //Exercise # 117
            
            Console.WriteLine("Please provide a number to be divided by 2.");
            int number = Convert.ToInt32(Console.ReadLine());                                     //Input for number parameter

            Console.WriteLine("\nPlease provide a second number to multiply by the first number.");//Input for number2 parameter
            int number2 = Convert.ToInt32(Console.ReadLine());

            VoidUsed.Math(number);                                                                //Void method used from Static class


            VoidUsed.Math(number, number2, out int result);                                       //Overload method and Output parameters
            Console.WriteLine("\nWhen you multiply " + number + " by " + number2 + 
                              " it equals: " + result + "!");

            Console.ReadLine();
        }
    }
}
