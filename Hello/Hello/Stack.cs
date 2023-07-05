using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public void Pop()
        {
            if(top != null)
            {
                top = top.Next;
                return;
            }
            Console.WriteLine("Stack is empty. Unable to pop");
        }
        public void Peak()
        {
            if (top != null)
            {
                Console.WriteLine(top.Data +" is at the top");
                return;
            }
            Console.WriteLine("Stack is empty");
        }
        public void Display()
        {
            Node tempNode = top;
            if(tempNode == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while(tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }
    }
}
