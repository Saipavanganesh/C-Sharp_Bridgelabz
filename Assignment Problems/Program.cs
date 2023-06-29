using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int factorial(int x)
        {
            if (x == 0)
            {
                return 1;

            }
            else
            {
                int total = x * factorial(x - 1);
                return total;
            }
        }
        static void Count(int nums)
        {
            if (nums == 99)
            {
                nums = 100;
                Console.WriteLine(nums);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(nums);
                nums++;
                Count(nums);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Display friends names\n" +
                "2.Convert the city name to Uppercase and Lowercase\n" +
                "3.Difference of squares\n" +
                "4.Printing a nummber 10 times\n" +
                "5.Finding no.of parts in the string\n" +
                "6.Generating 5 random numbers and finding their average\n" +
                "7.Finding perimeter and area of the circle\n" +
                "8.Printing next date using current date\n" +
                "9.Finding the execution time of the program\n" +
                "10.Finding numbers divisible by 7 but not 5 between 2000 and 3200\n" +
                "11.Factorial of the number using methods\n" +
                "12.Printing 1 to 100 without using loops\n" +
                "13.Finding the roots of a quadratic equation\n" +
                "14.Pling Plang Plong\n" +
                "15.Checks a,e,p in string\n" +
                "16.Average of float numbers\n" +
                "17.Finds prime number inside integer array\n" +
                "18.Shifting all zeroes to the end\n" +
                "19.Finding the first repeated element in the array\n");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1://Display friends names
                    Console.WriteLine("Program to display 5 friends names");
                    Console.WriteLine("Raj Kumar");
                    Console.WriteLine("Sai Kiran");
                    Console.WriteLine("Srinivas");
                    Console.WriteLine("Pradeep");
                    Console.WriteLine("Harry");
                    Console.ReadLine();
                break;


                case 2://Convert the city name to Uppercase and Lowercase
                    Console.WriteLine("Enter a city name");
                    String city = Console.ReadLine();
                    Console.WriteLine(city.ToUpper());
                    Console.WriteLine(city.ToLower());
                    Console.ReadLine();
                break;


                case 3://Difference of squares
                    Console.WriteLine("Enter any two numbers");

                    Console.WriteLine("Enter first number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("The sum of these numbers is " + (num1 + num2));
                    Console.WriteLine("The square of difference of these numbers is " + (num1 - num2) * (num1 - num2));
                    Console.ReadLine();
                break;


                case 4://Printing a nummber 10 times
                    Console.WriteLine("Enter a number");
                    String num = Console.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(num);
                    }
                    Console.ReadLine();
                break;


                case 5://Finding no.of parts in the string
                    int count = 1;
                    Console.WriteLine("Enter a string");
                    String s = Console.ReadLine();
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == ' ')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"There are {count} parts in the above string\n");
                    string[] parts = s.Split(' ');
                    for (int i = 0; i < parts.Length; i++)
                    {
                        Console.WriteLine($"part {i + 1} : {parts[i]}");
                    }
                    Console.ReadLine();
                break;


                case 6://Generating 5 random numbers and finding their average
                    Random random = new Random();
                    int sum = 0, count1 = 5, n;
                    Console.WriteLine("Random Numbers :");
                    for (int i = 0; i < 5; i++)
                    {
                        n = random.Next(1, 51);
                        Console.WriteLine(n);
                        sum = sum + n;

                    }
                    double avg = (double)sum / count1;
                    Console.WriteLine("Average is " + avg);
                    Console.ReadLine();
                break;


                case 7://Finding perimeter and area of the circle
                    Console.WriteLine("Enter the diameter");
                    double diameter = Convert.ToDouble(Console.ReadLine());
                    double radius = diameter / 2;

                    double perimeter = 2 * Math.PI * radius;
                    double area = Math.PI * Math.Pow(radius, 2);

                    Console.WriteLine("Perimeter is " + perimeter);
                    Console.WriteLine("Area is " + area);
                    Console.ReadLine();
                break;


                case 8://Printing next date using current date
                    Console.WriteLine("Enter a year:");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a month [1-12]:");
                    int month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a day [1-31]:");
                    int day = int.Parse(Console.ReadLine());

                    switch (month)
                    {
                        case 2:
                            if (year % 4 == 0) //For leapyear
                            {
                                if (day == 29)
                                {
                                    day = 1;
                                }
                                else
                                {
                                    day++;
                                }
                            }
                            else if (day == 28)
                            {
                                day = 1;
                            }
                            else
                            {
                                day = day++;
                            }
                            break;
                        case 4: //For April, June, September and November
                        case 6:
                        case 9:
                        case 11:
                            if (day == 30)
                            {
                                day = 1;
                            }
                            else
                            {
                                day = day++;
                            }
                            break;
                        default: //For remaining months
                            if (day == 31)
                            {
                                day = 1;
                            }
                            else
                            {
                                day = day++;
                            }
                            break;
                    }
                    if (month == 12)
                    {
                        year++;
                        month = 1;
                    }
                    else
                    {
                        month++;
                    }
                    Console.WriteLine($"Next Date is {year}-{month}-{day}");
                    Console.ReadLine();
                break;


                case 9://Finding the execution time of the program
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    sw.Stop();
                    Console.WriteLine("\n\nElapsed time is " + sw.ElapsedMilliseconds + " ms");
                    Console.ReadLine();
                    break;


                case 10://Finding numbers divisible by 7 but not 5 between 2000 and 3200
                    string numbers = "";
                    for (int i = 2000; i <= 3200; i++)
                    {
                        if (i % 7 == 0 && i % 5 != 0)
                        {
                            numbers = numbers + i + ", ";
                        }
                    }
                    Console.WriteLine(numbers);
                    Console.ReadLine();
                break;


                case 11://Factorial of the number using methods
                    Console.WriteLine("Enter a number");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Factorial of the number is {factorial(number)}");
                    Console.ReadLine();
                break;


                case 12://Printing 1 to 100 without using loops
                    Count(1);
                break;


                case 13://Finding the roots of a quadratic equation
                    Console.WriteLine("Enter the values of a,b,c to find the roots of the quadratic equation");
                    Console.WriteLine("Enter a value");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter b value");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter c value");
                    int c = int.Parse(Console.ReadLine());

                    double det = (b * b) - (4 * a * c);

                    if (det < 0)
                    {
                        Console.WriteLine("Roots are imaginary");
                        Console.ReadLine();
                    }
                    else
                    {
                        double r1 = (-b + Math.Sqrt(det)) / (2 * a);
                        double r2 = (-b - Math.Sqrt(det)) / (2 * a);
                        Console.WriteLine($"Roots are {r1} and {r2}");
                        Console.ReadLine();
                    }
                break; 


                case 14://Pling Plang Plong
                    Console.WriteLine("Enter a value");
                    int value = Convert.ToInt32(Console.ReadLine());
                    String result = "";
                    int divisible = 0;
                    if (value % 3 == 0)
                    {
                        Console.Write($"{result}Pling");
                        divisible++;
                    }
                    if (value % 5 == 0)
                    {
                        Console.Write($"{result}Plang");
                        divisible++;
                    }
                    if (value % 7 == 0)
                    {
                        Console.Write($"{result}Plong");
                        divisible++;
                    }
                    if (divisible == 0)
                    {
                        Console.WriteLine(value);
                    }
                    Console.ReadLine();
                break; 


                case 15://Checks a,e,p in string
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();

                    bool A = false;
                    bool E = false;
                    bool P = false;

                    if (str.Contains("a") || str.Contains("A"))
                    {
                        A = true;
                    }
                    if (str.Contains("e") || str.Contains("E"))
                    {
                        E = true;
                    }
                    if (str.Contains("i") || str.Contains("I"))
                    {
                        P = true;
                    }

                    if (A && E && P)
                    {
                        Console.WriteLine("All Present");
                    }
                    else if (A || E || P)
                    {
                        Console.WriteLine("One or more - Present");
                    }
                    else
                    {
                        Console.WriteLine("None Present");
                    }
                    Console.ReadLine();
                break;


                case 16://Average of float numbers
                    Console.WriteLine("Enter a number:");
                    float f1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter b number:");
                    float f2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter c number:");
                    float f3 = float.Parse(Console.ReadLine());
                    float average = (f1 + f2 + f3) / 3;
                    Console.WriteLine(average);
                    Console.ReadLine();
                break;

                case 17://Finds prime number inside integer array
                    int[] numberArray = new int[5];
                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        Console.WriteLine("Enter a number");
                        numberArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\n");
                    for (int j = 0; j < numberArray.Length; j++)
                    {
                        if (IsPrime(numberArray[j]))
                        {
                            Console.WriteLine($"{numberArray[j]} is prime");
                        }
                    }
                    Console.ReadLine();
                break;


                case 18://Shifting all zeroes to the end
                    int[] arr = new int[5];
                    int[] newarr = new int[arr.Length];
                    int index = 0;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Enter a value");
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != 0)
                        {
                            newarr[index] = arr[i];
                            index++;
                        }
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == 0)
                        {
                            newarr[index] = arr[i];
                            index++;
                        }
                    }

                    for (int i = 0; i < newarr.Length; i++)
                    {
                        Console.WriteLine(newarr[i]);
                    }
                    Console.ReadLine();
                break;


                case 19:
                    int[] array = new int[5];
                    int repeatedCount = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Enter a value");
                        array[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[i] == array[j])
                            {
                                Console.WriteLine($"Repeated element is {array[i]}");
                                repeatedCount++;
                                break;
                            }
                        }
                        if (repeatedCount != 0)
                        {
                            break;
                        }
                    }
                    if (repeatedCount == 0)
                    {
                        Console.WriteLine("No repeated element found");
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}
