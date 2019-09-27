using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
                Start:                                                                                             //Exercise # 154
                try
                {
                    Console.WriteLine("Please proivde a number to test the I/O, thanks.");
                    int number = Convert.ToInt32(Console.ReadLine());
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Desktop\C#\logs/log.txt", true))  //identifying user input and identifying it to my local file path
                {
                    file.WriteLine(number);                                                                        //Writing input into my file
                }
                    string Otext = File.ReadAllText(@"C:\Users\Owner\Desktop\C#\logs/log.txt");                    //Retrieving user input from my file
                    Console.WriteLine("Your number outputed from the I/O is: " + Otext);                           //User output from my file displayed

                Console.Read();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please enter a number.");
                goto Start;
                }
        }
    }
}
