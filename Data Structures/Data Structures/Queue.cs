using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
           front = null; 
           rear = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(rear ==  null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            rear.Next = newNode;
            rear = newNode;
        }
        public void Dequeue()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            if(front == rear) //To check if there is only one node
            {
                front = null;
                rear = null;
                return;
            }
            front = front.Next;
        }
        public void Peak()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine($"\n{front.Data} is at the front");
        }
        
        public void DisplayQueue()
        {
            Node temp = front;
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("\nDisplaying queue");
            while (temp != null )
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }
    }
}
