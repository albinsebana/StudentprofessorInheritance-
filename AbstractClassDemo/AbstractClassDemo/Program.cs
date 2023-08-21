using AbstractClassDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(12);
            Square square = new Square(5);
            Rectangle rectangle = new Rectangle(8, 16);


            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Area: {square.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }
}
