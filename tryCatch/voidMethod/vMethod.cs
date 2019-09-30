using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod
{
    public class vMethod
    {
        public void mathOp(int num1, int num2)                 //Using the void method taking in two integers
        {
            int result;

            result = num1 * 50;                               //Multiplication on num1
            Console.WriteLine("With the first number you provided: " + num1 + ", when you multiply it by 50 you get " + result + " !" +
                               "\nYour second number " + num2 + " was not used.");  //Displaying num2

        }
        
    }
}
