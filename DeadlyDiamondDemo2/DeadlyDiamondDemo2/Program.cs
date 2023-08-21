using DeadlyDiamondDemo2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Eat();
            lion.Roar();

            Tiger tiger = new Tiger();
            tiger.Eat();
            tiger.Roar();
        }
    }
}
