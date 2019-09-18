using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                List<int> divides = new List<int>() { 7, 29, 8, 4, 1, 256, 399, 999 };              //List of numbers
                Console.WriteLine("Please enter a number to divide a set of numbers.");
                decimal number = decimal.Parse(Console.ReadLine());

                foreach (decimal divide in divides)                                                //Our loop
                {
                    decimal total = divide / number;                                               //Iteration of diving each number by the user input number
                    Console.WriteLine("The number you chose: " + number + " divedes into " + divide + " to get the answer: " + string.Format("{0:0.##}", total));
                }
             }
            catch(DivideByZeroException ex)                                                        //Our exception errors
            {
                Console.WriteLine("You cannot divide a number by zero.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a number to divide by.");
            }
            catch(Exception ex)
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
