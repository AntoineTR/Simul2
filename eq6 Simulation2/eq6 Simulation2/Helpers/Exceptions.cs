using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LUJR.Helpers.Exceptions
{
    public class DatabaseAccessException : System.ApplicationException
    {
        public DatabaseAccessException() { }
        public DatabaseAccessException(string message) { }
        public DatabaseAccessException(string message, System.Exception inner) { }

        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected DatabaseAccessException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
