using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE # 114
            try
            {
                Console.WriteLine("Please provide a number to multiply by 100.");
                int number = Convert.ToInt32(Console.ReadLine());
                int ret;

                intMath math1 = new intMath();
                ret = math1.math1(number);                                                   //Method with integer input

                Console.WriteLine("Your answer is " + ret + "!");

                Console.WriteLine("\nPlease provide a number to divide by 100.");
                decimal number2 = decimal.Parse(Console.ReadLine());

                decimal ret1;

                intMath math2 = new intMath();
                ret1 = math2.math1(number2);                                                 //Same method with decimal input and integer output
                int ret11 = Convert.ToInt32(ret1);

                Console.WriteLine("Your answer is " + ret11 + "!");

                Console.WriteLine("\nPlease provide a number to subract it by 100.");
                string number3 = Console.ReadLine();

                string ret2;

                intMath math3 = new intMath();
                ret2 = math3.math1(number3);                                                  //Same method name with string input and integer output
                int ret22 = Convert.ToInt32(ret2);

                Console.WriteLine("Your answer is " + ret22 + "!");
            }
            catch (DivideByZeroException ex)                                                        //Our exception errors
            {
                Console.WriteLine("You cannot divide a number by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally                                                                                //Allowing the program to still execute
            {
                Console.ReadLine();
            }

        }
    }
}
