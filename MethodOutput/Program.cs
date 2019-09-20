using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOutput
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                      //Exercise # 117
            Console.WriteLine("Please provide a number to be divided by 2.");
            int number = Convert.ToInt32(Console.ReadLine());                         //Input for our parameters

            int output;

            voidMethod voidMethod = new voidMethod();                                 //Static class
            voidMethod.math(number);                                                  //Void method
            voidMethod.math(number, out output);                                      //Overload method and Output parameter


            Console.ReadLine();
        }
    }
}
