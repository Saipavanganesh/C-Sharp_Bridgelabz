using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Project
{
    internal class Gen
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        public void gener()
        {
            Gen gen = new Gen();
            bool resultInt = Compare<int>(10, 10);
            bool resultBool = Compare<bool>(true, false);
            bool resultDouble= Compare<double>(10, 10.0);
            bool resultString= Compare<string>("Ganesh", "ganesh");
            Console.WriteLine(resultInt);
            Console.WriteLine(resultBool);
            Console.WriteLine(resultDouble);
            Console.WriteLine(resultString);
            
        }
    }
}
