using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Project
{
    internal class HashtableDemo
    {
        public void htCollections()
        {
            Hashtable ht = new Hashtable();
            ht.Add("EName", "Ganesh");
            ht.Add("EId", 1010);
            ht.Add("Email", "ganesh@gmail.com");
            ht.Add("ELoc", "Hyd");
            
            foreach(object obj in ht.Keys)
            {
                Console.WriteLine($"{obj} : {ht[obj]}");
            }
            Console.ReadLine();
        }
    }
}
