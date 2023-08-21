using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondDemo2.Model
{
    internal class Lion :Eater,Roarer
    {
        public void Roar()
        {
            Console.WriteLine("Lion Roars...");
        }
        public  void Eat()
        {
            Console.WriteLine("Lion is Eating ");
        }
    }
}
