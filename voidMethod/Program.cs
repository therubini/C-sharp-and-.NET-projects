using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
//EXERCISE # 113
            try
            { 
                    Console.WriteLine("Please provide a number to do a mathimatical operation on.");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please provide a second number.");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    vMethod vMethod = new vMethod();                                                   

                    vMethod.mathOp(num1: number1, num2: number2);                                                 //Class method is called and passing two numbers
            }
            catch (FormatException ex)                                                                            //Exception errors 
            {
                Console.WriteLine("Please enter a number, thanks.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
