using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exceptions
    {
        public void Divide()
        {
            try
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 % 2 > 0)
                {
                    throw new DivideByOddException();
                }
                Console.WriteLine("Division is " + (num1 / num2));
            }
            catch (DivideByZeroException zeroException)
            {
                Console.WriteLine(zeroException.Message);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message + " Give only integer input.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("End of finally block");
            }
            Console.WriteLine("Program ended");
        }
    }
}
