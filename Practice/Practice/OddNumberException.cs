using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Cannot divide by an odd number";
            }
        }
    }
}
