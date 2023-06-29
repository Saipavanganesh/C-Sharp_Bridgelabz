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
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a value");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Repeated element is {arr[i]}");
                        count++;
                        break;
                    }
                }
                if(count != 0)
                {
                    break;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No repeated element found");
            }
            Console.ReadLine();
        }
    }
}
