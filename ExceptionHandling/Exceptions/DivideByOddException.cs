using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class DivideByOddException : Exception
    {
        public override string Message
        {
            get
            {
                return "Cannot divide by an Odd Number";
            }
        }
    }
}
