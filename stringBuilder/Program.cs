using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello Tech World!";
            string b = " What do you want to do when you're done with the ";
            string c = "bootcamp?";

            c = c.ToUpper();                                                        //This turns a string to uppercase

            Console.WriteLine(a + b + c);                                           //Concatenate the strings

            StringBuilder sb = new StringBuilder();                                 //StringBuilder
            sb.Append(" It adds on to the string without the sacrifice of memory.");//Appending string
            sb.Append("\nIt's really useful when dealing with large amounts of strings.");
            sb.Append("\nIn csharp, StringBuilder is a class which is used to represent a mutable string of characters.");
            sb.Append("\nIf any changes made to the string object like add or modify an existing value,");
            sb.Append(" \nthen it will simply discard the old instance in memory and create a new instance.");

            sb.Insert(0, "\n\n\tThis is a StringBuilder.");                          //Inserting a string to the beginning 

            sb.Replace("csharp", "c#");                                              //Replacing a word in our string with another word
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
