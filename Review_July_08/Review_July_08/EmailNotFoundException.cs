using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_July_08
{
    internal class EmailNotFoundException : Exception
    {
        public override string Message
        {
            get
            {
                return "No Email found in the given text";
            }
        }
    }
}
