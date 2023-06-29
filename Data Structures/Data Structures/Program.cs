using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.DisplayStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.DisplayStack();
            stack.Pop();
            stack.Pop();
            stack.Push(100);
            stack.DisplayStack();
            stack.Peak();
        }
    }
}
