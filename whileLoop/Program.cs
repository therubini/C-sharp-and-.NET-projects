using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 28)
            {
                Console.WriteLine("While Loop: {0}", counter);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
