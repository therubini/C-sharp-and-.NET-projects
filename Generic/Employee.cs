using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    public class Employee<t>                                      //Using a generic type parameter in the Class
    {
                public List<t> things = new List<t>();            //Property with the generic data type
    }
}
