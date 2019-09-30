using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ageException: Exception                                   //Created specific error exception inherited from Exception class
    {
        public ageException()
            : base() { }
        public ageException(string message)
            : base(message) { }
    }
}
