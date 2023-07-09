using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Practice
{
    internal class ReExDemo
    {
        public string CheckPattern(string input, string pattern)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            if (isValid)
            {
                return "Valid";
            }
            return "Invalid";
        }
        public void reg()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            string namePattern = @"^[\p{L}\s]{3,}$"; //[\p{L}] accepts any unicode character
            string emailPattern = @"^[A-za-z0-9]+@[a-z]+[.com]$"; 
            string phoneNumberPattern = @"^\d{10}$";
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$"; //(?=. is called positive lookout

            Console.WriteLine(CheckPattern(name, namePattern));
            Console.WriteLine(CheckPattern(phoneNumber, phoneNumberPattern));
            Console.WriteLine(CheckPattern(email, emailPattern));
            Console.WriteLine(CheckPattern(password, passwordPattern));
        }
    }
}

