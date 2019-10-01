using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConstructors
{
    public class Constructors
    {
        public Constructors(int number, int number2) : this("You didn't provide a name...Oh Well," , number, number2) //Constructor chaining creatd
        {

        }
        public Constructors(string firstname, int number, int number2)  
        {
            Result= number * number2;

            Firstname = firstname;
            Number = number;
            Number2 = number2;
            
        }

        public int Result { get; set; }
        public int Number { get; set; }
        public int Number2 { get; set; }
        public string Firstname { get; set; }


    }
}
