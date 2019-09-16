using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine("DO While Loop: {0}", counter);
                counter++;
            } while (counter < 28);
            Console.ReadLine();

        }
    }
}
