using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructs115
{
    public class twoparameters
    {
        public int math(int num1, int num2 = 5)        //Created an optional parameter for the second number
        {

            int result = num1 * num2;
            
            return result;
        }
    }
}


