using InterfaceDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(10.8);


            Console.WriteLine($"Circle Area: {circle.CalculateArea()} ");
        }
    }
}
