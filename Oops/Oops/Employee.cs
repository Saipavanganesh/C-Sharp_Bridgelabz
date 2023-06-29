using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Employee
    {
        public string name;
        public int salary;
        public string role;

        public void Details()
        {
            Console.WriteLine($"{name} is earning {salary} working as {role}");
        }
        public void ShowCompany()
        {
            Console.WriteLine("This person is working in TCS");
        }
        
    }
    

}
