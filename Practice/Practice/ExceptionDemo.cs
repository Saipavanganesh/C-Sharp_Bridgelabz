using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ExceptionDemo
    {
        public void exc()
        {
            try
            {
                Console.WriteLine("Enter a value");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another value");
                int b = int.Parse(Console.ReadLine());
                if(b % 2 > 0)
                {
                    throw new OddNumberException();
                }
                Console.WriteLine($"Quotient is {a / b}");
            }
            catch (DivideByZeroException dbz) 
            {
                Console.WriteLine(dbz.Message);
            }
            catch (FormatException fe) 
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
