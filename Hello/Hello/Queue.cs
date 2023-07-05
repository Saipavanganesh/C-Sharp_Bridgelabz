using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
            front=null;
            rear=null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(rear == null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            rear.Next = newNode;
            rear = newNode;
        }
        public void Pop()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            if(front == rear)
            {
                front = null;
                rear = null;
                return;
            }
            front = front.Next;
        }
        public void Peak()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine(front.Data + " is at the front");
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node tempNode = front;
            while(tempNode != null)
            {
                Console.Write($"{tempNode.Data} ");
                tempNode = tempNode.Next;
            }
        }
    }
}
