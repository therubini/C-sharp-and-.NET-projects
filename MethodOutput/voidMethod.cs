using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOutput
{
    static class VoidUsed                                                                      
    {

        //int output;
        public static void Math(int x)                                                   //Void method
        {

             Console.WriteLine("\nYour first number divided by 2 equals: " + x/2 + "!");
        }
        public static void Math(int x, int y, out int output)                                   //Static void overload method with output parameter
        {
            int result = x* y;
            output = result;           
        }
    }
}
