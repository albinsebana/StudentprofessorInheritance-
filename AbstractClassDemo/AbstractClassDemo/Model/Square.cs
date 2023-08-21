using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo.Model
{
    internal class Square : Shape
    {
        public int Side { get; set; }

        public Square() { } 

        public Square(int side) 
        {
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side*Side;
        }

    }
}
