using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Project
{
    internal class ArraylistDemo
    {
        public void alCollections()
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add("Ganesh");
            arrayList.Insert(2, 2.3);
            Console.WriteLine("Displaying array list");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            } 
            Console.ReadLine();
        }

    }
}
