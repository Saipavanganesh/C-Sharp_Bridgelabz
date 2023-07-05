using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_June3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 2, 6, 1, 5};
            
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            foreach (int k in arr)
            {
                Console.Write(k +" ");
            }
            Console.ReadLine();
        }
    }
}
