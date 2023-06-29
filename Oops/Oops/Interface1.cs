using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    interface Interface1
    {
        void add(int a, int b);
    }
    interface Interface2 : Interface1
    {
        void sub(int a, int b);
    }
    interface Interface3
    {
        void add(int a, int b);
    }
    class ImplementingInterfaces : Interface2   
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class MulInherit : Interface1, Interface3
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class Implementation
    {
        static void Main(string[] args)
        {
            ImplementingInterfaces obj = new ImplementingInterfaces();
            obj.add(1, 2);
            obj.sub(1, 2);

            MulInherit mul = new MulInherit();
            mul.add(3, 4);
            Console.ReadLine();
        }
    }
}
