using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
                Start:
                try
                {
                    Console.WriteLine("Please choose a day in the week.");
                    string theDay = Console.ReadLine();                                       //User input
                    theDay = theDay.First().ToString().ToUpper() + theDay.Substring(1);       //Changing first letter to uppercase if user does not
                    if (theDay.All(char.IsDigit))                                             //No integers accepted as input
                {
                        throw new Exception("No numbers,");
                    }

                    DayOfWeek daysofweek = new DayOfWeek();                                   //Days of the week enumeration built in
                    
                    daysofweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), theDay);            //Parsed users input to match our enumerator
                 

                    Console.WriteLine("\nThe day of the week you choose is " + daysofweek + ", that is a great day!");
                    Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message + " Please try agaiin.\n");
                goto Start;                                                                   //Starts to the original question again
                }
            }
        }
}

