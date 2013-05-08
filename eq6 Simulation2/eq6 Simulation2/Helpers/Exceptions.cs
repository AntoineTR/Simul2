using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LUJR.Helpers.Exceptions
{
    class DatabaseAccessException : Exception
    {

        public DatabaseAccessException(string pMess) : base(pMess) { }

    }
}
