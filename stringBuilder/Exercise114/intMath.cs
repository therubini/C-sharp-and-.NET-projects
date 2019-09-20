using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class intMath                                     //Class created
    {
        public int math1(int num1)                    //Integer input
        {
            int result;

            result = num1 * 100;
            return result;
        }
        public int math1(decimal num2)            //Decimal input 
        {
            decimal result;

            result = 100 / num2;

            int rt = Convert.ToInt32(result);
            return rt;
        }

        public int math1(string num3)              //String input
        {
            int num33 = Convert.ToInt32(num3);
            int result;

            result = 100 - num33;

            return result;
        }

    }
}
