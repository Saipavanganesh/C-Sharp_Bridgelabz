using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcTest excTest = new ExcTest();
            excTest.Divide();
            Console.ReadLine();
        }
    }
}
