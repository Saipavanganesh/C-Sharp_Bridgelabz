using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Inherited : Employee
    {
        public new void ShowCompany()
        {
            Details();
            Console.WriteLine("This person works in Infosys");
        }
    }
}
