using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Project
{
    internal class SepLists
    {
        public void SeperateLists()
        {
            List<int> iList = new List<int>();
            iList.Add(10);
            iList.Add(20);
            iList.Add(30);
            iList.Add(40);
            foreach (int i in iList) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<string> sList= new List<string>();
            sList.Add("John");
            sList.Add("Scott");
            sList.Add("Jim");
            sList.Add("Tony");
            foreach (string s in sList) 
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            List<double> dList = new List<double>();
            dList.Add(10.45);
            dList.Add(20.22);
            dList.Add(30);
            dList.Add(40.5);
            foreach (double d in dList) 
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
<<<<<<< HEAD
            Console.ReadLine();
=======
            
>>>>>>> Files
        }
    }
}
