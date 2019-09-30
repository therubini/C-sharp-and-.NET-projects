using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConstructors
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                       //Exercise # 162
           
                const string words = "{0} the number: {1} mulitiplyed by {2} equals {3}";      //Const variable 
                Console.WriteLine("Please provide your first name.");
                string firstname = Console.ReadLine();
                Console.WriteLine("\nPlease provide a number.");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPlease provide another number.");
                int number2 = Convert.ToInt32(Console.ReadLine());                      

                int result = number * number2;
                if (firstname == " ")
                {
                    var constructors = new Constructors(firstname, number, number2, result);    //Var keyword implemented
                    Console.WriteLine(words, constructors.Firstname, constructors.Number, constructors.Number2, constructors.Result);
                }
                else
                {
                    var constructors = new Constructors(number, number2, result);              //Constructor chain implemented
                    Console.WriteLine(words, constructors.Firstname, constructors.Number, constructors.Number2, constructors.Result);
                    Console.Read();
                }
        }
    }
}
