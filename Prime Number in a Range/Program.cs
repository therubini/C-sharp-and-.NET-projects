using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Codes
{                           // A program to obtain all prime number in a given range ///
    public class Program
    {
        public static void Main()
        {
            int x, i, ctr, l, r;

            
            Console.Write("Find the prime numbers within a range of numbers:\n");

            Console.Write("\n\n"); 
            Console.Write("Input starting number of range: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", l, r);

            for (x = l; x <= r; x++)      //Get all numbers within range
            {
                ctr = 0;

                for (i = 2; i <= x / 2; i++)  //Prime numbers divide itself and by 1
                {
                    if (x % i == 0) //If the remainder is 0, it is a prime number
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && x != 1) //Getting all number's with remainder 0 and not including the number 1
                    Console.Write("{0} ", x);  //Result
            }
            Console.ReadLine();
        }
    }
}
