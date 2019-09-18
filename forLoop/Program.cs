using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
 //EXERCISE #1-3

            string[] letters = new string[5];                                //an array with allocated memory space of 5

            for (int i = 0; i < 5; i++)                                      //if you add i-- it will create an INFINITE LOOP
            {
                Console.WriteLine("Enter any text you feel like writing:");
                letters[i] = string.Format(Console.ReadLine());              //input to add to the array
            }

            foreach (string letter in letters)
            {
                Console.WriteLine("\n" + letter);                            //this will ouput the value of our array input
            }
            Console.ReadLine();

//EXERCISE # 4 COMPARISON OPERATOR '<'

            Console.WriteLine("\nEnter an array capacity above 20.");
            int capacity = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[capacity];

            for (int j = 0; j < numbers.Length; j++)
            {
                if (j < 21)                                                   //a comparison operator '<' to evalute the array
                {
                    Console.WriteLine("I won't let you go above 21 " + j + " hahaha!!");
                }
            }
            Console.ReadLine();

//EXERCISE # 5 COMPARISON OPERATIOR '<='
            
            List<double> prices = new List<double>() { 28.90, 14.20, 9.40, 80.63, 1.23, 50.21, 16.35, 38.75, 30.50 };

            foreach (double price in prices)
            {
                if (price <= 30.50)                                                  //a comparison operator "<=" to evalute the array
                {
                    Console.WriteLine("\nPrices equal or under $30.50: " + price);
                }
            }

// EXERCISE #6-8 

            List<string> states = new List<string>() { "Maryland", "Michigan", "Montana", "Missouri", "Massachusetts", "Mississippi", "Minnesota", "Maine" };
            Console.WriteLine("\nChoose a US state that starts with the letter M to find it's index number.");
            string m = Console.ReadLine();

            if (!states.Contains(m))
            {
                Console.WriteLine("The US state you entered does not exist in our array!");  //message if text is not found in the array
            }
            else
            {
                foreach (string state in states)
                {
                    if (m == state)
                    {
                        Console.WriteLine("\nThe state " + m + " appears in Index: " + states.IndexOf(state));                    //returns the index of the string 
                        break;
                    }
                }
            }
            Console.ReadLine();

// #EXERCISE # 9

            List<string> names = new List<string>() { "John", "Jon", "Jonathan", "Jay", "Jeff", "Jack", "Jerry", "J", "Jordan", "James", "Jesus", "Jon" };
            Console.WriteLine("Choose a male name that starts with the letter J to display the index in the array.");

            string jName = Console.ReadLine();

            if (!names.Contains(jName))
            {
                Console.WriteLine(jName + " must not be a popular J name, sorry!");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < names.Count; i++)                               //Iterates the array
                {
                    int index = i;
                    if (jName == names[i])                                         //Will locate name and find it's iteration
                    {
                        Console.WriteLine(names[i] + " is at index: " + index);
                    }
                }

                Console.ReadLine();
            }

//EXERCISE # 11

            List<string> countries = new List<string>() { "USA", "Italy", "Venezuela", "USA", "Canada", "Russia", "Ireland", "China", "Japan", "India", "USA", "Canada", "Japan", "USA" };
            Console.WriteLine("Choose a country to see if it's in our array.");
            string theCountry = Console.ReadLine();

            List<string> count = new List<string>();

            foreach (string country in countries)
            {
                if (country ==  theCountry)
                {
                    count.Add(country);                                                         //Iterates the number of times it appears or does not appear in the array 
                }
            }
            Console.WriteLine("The country " + theCountry + " you entered occurs " + count.Count + " times.");
            Console.ReadLine();
        }
    }
}
