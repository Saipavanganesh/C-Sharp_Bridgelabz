using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public abstract class Shape
    {
        public double length, width, radius;
        public const float pi = 3.14F;
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return length * width;
        }
    }
    
    public class Square : Shape
    {
        public Square(double length)
        {
            this.length = length;
        }
        public override double GetArea()
        {
            return length * length;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius) {
        this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }
    }

    public class TestShapes
    {
        //static void Main(string[] args)
        //{
        //    Rectangle rect = new Rectangle(10, 12.5);
        //    Square sq = new Square(2.5);
        //    Circle circle = new Circle(30);
        //    Console.WriteLine($"Area of Rectangle is {rect.GetArea()}");
        //    Console.WriteLine($"Area of Square is {sq.GetArea()}");
        //    Console.WriteLine($"Area of Circle is {circle.GetArea()}");
        //    Console.ReadLine();
        //}
    }
}
