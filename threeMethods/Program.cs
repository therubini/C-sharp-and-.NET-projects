using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE #111 CREATING A CLASS WITH THREE METHODS
            try
            {
                Console.WriteLine("Please provide a number to do mathimatical operations on.");
                double number = double.Parse(Console.ReadLine());
                double ret;
                double ret1;
                double ret2;

                threeMethods a = new threeMethods();          //My class for my Mathimatical operations

                ret = a.addition(number);                     //Calling addition method
                ret1 = a.multipy(number);                     //Calling multiplication method
                ret2 = a.divide(number);                      //Calling division method
                Console.WriteLine("Adding your number: " + number + " by 10 equals " + ret +
                                   "\nMultiplying your number: " + number + " by 10 equals " + ret1 +
                                   "\nDividing your number: " + number + " by 10 equals " + ret2);


            }
            catch (FormatException ex)                        //Exception errors 
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
