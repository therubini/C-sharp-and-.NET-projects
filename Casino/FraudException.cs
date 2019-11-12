using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class FraudException : Exception                                  //Inherit from Exceptions
    {
        public FraudException()
            : base() {}                                                     //Code that is inherited from the base exception
        public FraudException(string message)
            : base(message) { }
    }
}
