using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            Next = null;
        }
    }
    public class Stack
    {
        Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty. Unable to pop");
                Console.Read();
                return;
            }
            top = top.Next;
        }
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                Console.Read();
                return;
            }
            Console.WriteLine($"{top.Data} is at the top");
            Console.Read();
        }
        public void DisplayStack()
        {
            Node temp = top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                Console.Read();
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.Read();
        }
    }
}
