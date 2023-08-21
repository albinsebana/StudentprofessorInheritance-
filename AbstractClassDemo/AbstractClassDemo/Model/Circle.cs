using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo.Model
{
    internal class Circle :Shape
    {
        public double Radius { get; set; }
       // public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
           double pi = 3.14159265359;
            return pi * Radius * Radius;//Math.PI  can be used to determine the value of the pi
        }
    }
}
