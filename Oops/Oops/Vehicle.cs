using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Vehicle
    {

        public void Journey(string vehicleName, string name, int totalTires)
        {
            if (totalTires == 2)
            {
                Console.WriteLine($"{name} rides {vehicleName}");

            }
            else if (totalTires == 4)
            {
                Console.WriteLine($"{name} drives {vehicleName}");

            }
            else
            {
                Console.WriteLine($"{name}, {vehicleName} not a car or a bike");
            }
        }
    }
}
