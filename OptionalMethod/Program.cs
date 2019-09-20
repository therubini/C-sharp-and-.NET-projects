using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructs115
{
    class Program
    {
        static void Main(string[] args)
        {
                                //EXERCISE # 115

            Console.WriteLine("Please provide a number to multiply by.");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Providing a second number to multiply is OPTIONAL.");
            string numberTwo = Console.ReadLine();                                        //Passing the second optional number as a string

            int ret;
            int ret1;

            twoparameters twoparameters = new twoparameters();                           //Class


            if (numberTwo is "")                                                         //Comparing if second number has a value
            {
               ret= twoparameters.math(number1);                                         //Calling method with one parameter

               Console.WriteLine("\nYour first number: " + number1 + " was multiplied by 5 to equal " + ret + "!"); 
            }
            else
            {
                int number2 = Convert.ToInt32(numberTwo);                               //If second number has value, changed from string to int
                ret1 = twoparameters.math(number1, number2);                            //Calling method using two parameters
                Console.WriteLine("\nMultiplying " + number1 + " by " + number2 + " equals " +  ret1 + "!");
            }

            Console.ReadLine();
        }
    }
}
