using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Program
    {
        public delegate void AddDelegate(int a, int b); //1.Defining delegates
        public delegate string GreetDelegate(string a);
        public delegate string RemDelegate(int a, int b);
        public delegate string LambdaDelegate(string a);
        public void AddNums(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }
        public void SubNums(int a, int b)
        {
            Console.WriteLine($"Difference is {a - b}");
        }
        public void MulNums(int a, int b)
        {
            Console.WriteLine($"Product is {a * b}");
        }
        public static string Greet(string name)
        {
            return $"Hello {name}";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums); //2.Instantiating delegates
            GreetDelegate gd = new GreetDelegate(Greet);

            ad(1, 2);               //3.Calling delegates 
            string str = gd("Ganesh");
            Console.WriteLine(str);
            Console.WriteLine();

            ad.Invoke(100, 200);
            string str2 = gd.Invoke("Sai Pavan");
            Console.WriteLine(str2);
            Console.WriteLine();

            ad = ad + p.SubNums + p.MulNums; //Multicasting Delegates
            ad.Invoke(6, 5);
            Console.WriteLine();

            RemDelegate rd = delegate (int a, int b) //Anonymous Delegates
            {
                return ($"Remainder is {a % b}");
            };
            string rem = rd.Invoke(6, 4);
            Console.WriteLine(rem);
            Console.WriteLine();

            LambdaDelegate ld = (name) => //Lambda Function
            {
                return $"Hi {name}, This is a lambda function";
            };
            string greet = ld.Invoke("Ganesh");
            Console.WriteLine(greet);
            Console.WriteLine();

            

            Console.ReadLine();
        }
    }
}
