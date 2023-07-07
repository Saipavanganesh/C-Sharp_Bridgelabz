using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reg_Exp
{
    public class Program
    {
        public string CheckPattern(string input, string pattern)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            if (isValid)
            {
                //Console.WriteLine($"Valid pattern for {input}");
                return "Valid";
            }
            //Console.WriteLine($"Check Again!!!! Invalid Pattern for {input}");
            return "Invalid";
        }
        static void Main()
        {
            Program pr = new Program();
            //string name = "Sai Pavan Ganesh";
            //string email = "saipavanganesh@email.com";
            //string phoneNumber = "9876543210";
            //string password = "Password@123";
            Console.WriteLine("Enter details");
            string name = Console.ReadLine();
            string namePattern = "^( ?[a-zA-z]{3,})*$";
            Console.WriteLine(pr.CheckPattern(name, namePattern));

            string email = Console.ReadLine();
            // string emailPattern = "^[A-Za-z0-9]+[@]+[a-z]+[.com]";
            string emailPattern = "^[a-zA-Z0-9]{3,15}@[a-zA-Z]{3,10}.(com|org)$";
            Console.WriteLine(pr.CheckPattern(email, emailPattern));

            string phoneNumber = Console.ReadLine();
            string phoneNumberPattern = "^[6-9]{1}[0-9]{9}";
            Console.WriteLine(pr.CheckPattern(phoneNumber, phoneNumberPattern));

            string password = Console.ReadLine();
            string passwordPattern = "^[a-zA-Z0-9!@#$%^&*.,]{8,}";
            //string passwordPattern = "^[A-Z]{1}[!@#$%^&*]{1}[0-9]{1}[a-z]{1}[a-zA-Z0-9]{1,4}$";
            Console.WriteLine(pr.CheckPattern(password, passwordPattern));

            Console.ReadLine();
        }
    }
}
