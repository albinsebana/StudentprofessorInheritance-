using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondDemo2.Model
{
    internal class Tiger : Eater, Roarer
    {
        public  void Eat()
        {
            Console.WriteLine("tiger is eating ");
        }

        public void Roar()
        {
            Console.WriteLine("Tiger  Roars") ;
        }
    }
}
