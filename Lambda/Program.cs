using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program                                 //Exercise # 140 List created with ten names, at least two or more firs names are joe,
    {                                             //and using foreach and lambda methods
        static void Main(string[] args)
        {

            Method method = new Method();
            method.mOne();                        //Gets all names starting with Joe using 'foreach' loop
            method.mTwo();                        //Gets all names starting with Joe using 'Lambda'
            method.mThree();                      //Gets all names with an ID greater than 5 using 'Lambda'

            //method.mFour();                     //Created to check entire list
            Console.ReadLine();
        }
    }
}

