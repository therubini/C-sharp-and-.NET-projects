using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {                                                            //Exercise # 137
        static void Main(string[] args)
        {
            Number number = new Number();                        //Object called
            number.Amount = 27.99m;                              //Value assigned

            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }
    }
}
