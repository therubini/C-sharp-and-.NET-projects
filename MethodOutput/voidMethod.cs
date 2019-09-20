using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOutput
{
    class voidMethod
    {
        public static void math(int x)                                                   //Void method
        {
            Console.WriteLine("Your number divided by 2 equals: " + x / 2 + "!");

        }
        public static void math(int x, out int result)                                   //Static void overload method with output parameter
        {
            result = x / 2;
            Console.WriteLine("\nBy using an overload and an output we can get the result: " + result + "!");
        }
    }
}
