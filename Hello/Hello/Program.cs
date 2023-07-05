using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {  
        static void StackOperations()
        {
            Console.WriteLine("Stack");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Display();
            stack.Pop();
            stack.Peak();
            stack.Push(5);
            stack.Display();
            Console.WriteLine();
        }
        static void QueueOperations()
        {
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Display();
            queue.Pop();
            queue.Peak();
            queue.Push(5);
            queue.Display();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //StackOperations();
            QueueOperations();
            Console.ReadLine();
        }
    }
}
