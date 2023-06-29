using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Person
    {
        public string name;
        public void IntroduceTo(string anotherName)
        {
            Console.WriteLine($"Hi {anotherName}, Iam {name}");
        }
    }
}
