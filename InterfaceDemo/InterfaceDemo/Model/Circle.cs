using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double radius) 
        {
            Radius = radius;
        }
        public double CalculateArea()
        { 
            return Math.PI*Radius*Radius;
        }

    }
}
