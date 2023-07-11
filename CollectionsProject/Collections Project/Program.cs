using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList");
            ArraylistDemo ald = new ArraylistDemo();
            ald.alCollections();

            Console.WriteLine("\n\nHashTable");
            HashtableDemo hashtableDemo = new HashtableDemo(); 
            hashtableDemo.htCollections();

            Console.WriteLine("\n\nSeperate Lists");
            SepLists sl = new SepLists();
            sl.SeperateLists();

            Console.WriteLine("\n\nGenerics");
            Gen gen = new Gen();
            gen.gener();

            Console.ReadLine();
        }
    }
}
