using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                          //Exercise # 165
        Start:
            try
            {
                Console.WriteLine("Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)                                                                       //Catching error if age is zero or below
                {
                    ageException ageException = new ageException();                                //Calling created exception
                    throw ageException;
                }

                DateTime yearBorn = DateTime.Now.AddYears(-age);
                Console.WriteLine("\nYou were born in the year: {0}", yearBorn.ToString("yyyy"));
                Console.ReadLine();
            }
            catch(ageException)                                                                    //Exception implemented if any zeros or negative numbers
            {
                Console.WriteLine("No negative numbers or zero.\n");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                goto Start;
            }
        }
    }
}
