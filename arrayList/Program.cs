using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    class Program
    {
        static void Main()
        {
            string[] strArray = { "Hello", "World Domination", "Billionare", "Family", "Conan" };                              //Our string array

            Console.WriteLine("Pick a number between 0-4 in order to find out the string value in the array!");
            string sArray = Console.ReadLine();
            int sArray1 = Convert.ToInt32(sArray);

            if (sArray1 >= 0 && sArray1 <= 4)                                                                                //Our Boolean logic
            {
                Console.WriteLine("Good job choosing " + strArray[sArray1] + "!");                                            //To recover the value in the array
            }
            else
            {

                Console.WriteLine("You did not choose between 0-4 to find the string value!");                                 //If user does not pick with the paramaters given

            }

            int[] numArray = { 23, 34, 500, 690, 11111 };                                                                      //Our int array

            Console.WriteLine("\n\nPick a number between 0-4 in order to find out the integer value for that index!");
            string nArray = Console.ReadLine();
            int nArray1 = Convert.ToInt32(nArray);


            if (nArray1 >= 0 && nArray1 <= 4)                                                                                  //Our Boolean logic
            {
                Console.WriteLine("Your number is " + numArray[nArray1] + "!");                                                    //To recover the value in the array
            }
            else
            {
                Console.WriteLine("You did not choose between 0-4 to find the integer value!");                                     //If user does not pick with the paramaters given
            }

            List<string> theList = new List<string>();
            theList.Add("Farmer");
            theList.Add("Zoo Keeper");
            theList.Add("Actor");
            theList.Add("Commando");
            theList.Add("Jedi");

            Console.WriteLine("\n\nPick a number between 0-4 in order to find out what you were meant to be!!!");
            string sList = Console.ReadLine();
            int sList1 = Convert.ToInt32(sList);

          if (sList1 >= 0 && sList1 <= 4)                                                                 //Our Boolean logic
          {
           Console.WriteLine("You will be a " + theList[sList1] + "!");                                   //To recover the value in the array
          }
          else
          {
          Console.WriteLine("You did not choose between 0-4 to find out what destiny has for you!!!");    //If user does not pick with the paramaters given
          }

          Console.ReadLine();
        }
    }
}
