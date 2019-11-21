using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiice_c_Sharp
{
    class Program
    {                                 //User choses words then user given a range to pick in order to remove the character for the word/words
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word.");            
            string a = Console.ReadLine();
            int b = a.Length;
            Console.WriteLine("Choose a number between 0 and {0}", b);
            int num = Convert.ToInt32(Console.ReadLine());
            string word = a.Remove(num, 1);
            Console.WriteLine("your new word is: {0}", word);

            

            Console.ReadLine();           
            
        }
        
       
    }
}
