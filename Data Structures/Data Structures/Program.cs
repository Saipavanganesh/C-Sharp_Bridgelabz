using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Program
    {
        static void StackOperations()
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

            Console.Read();
        }
        static void QueueOperations()
        {
            Queue queue = new Queue();

            queue.DisplayQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            queue.DisplayQueue();
            queue.Dequeue();
            queue.Dequeue();

            queue.Peak();
            queue.Enqueue(100);
            queue.DisplayQueue();

            Console.Read();
        }

        static void HashTableOperations()
        {
            HashTable hashTable = new HashTable();

            hashTable.Add(13, "Sai");
            hashTable.Add(19, "Pavan");
            hashTable.Add(10, "Ganesh");
            hashTable.Add(23, "Sai Pavan");
            hashTable.Add(33, "Jim");
            hashTable.Add(11, "Michael");
 
            Console.WriteLine("Value for key 13: " + hashTable.Get(13));
            Console.WriteLine("Value for key 19: " + hashTable.Get(19));
            Console.WriteLine("Value for key 10: " + hashTable.Get(10));
            Console.WriteLine("Value for key 23: " + hashTable.Get(23));
            Console.WriteLine("Value for key 39: " + hashTable.Get(33));
            Console.WriteLine("Value for key 11: " + hashTable.Get(11));
            Console.WriteLine("Value for key 21: " + hashTable.Get(21));

            Console.Read();
        }
        static void Main(string[] args)
        {
            //StackOperations();
            //QueueOperations();
            HashTableOperations();
            
        }
    }
}
