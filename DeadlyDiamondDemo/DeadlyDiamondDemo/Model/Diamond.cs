using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondDemo.Model
{
    internal class Diamond :Circle , Reactangle// Drawable   //multiple inheritance does not support 
    {
        // Console.WriteLine("Drawing a diamond.");
        public void Draw()
        {
            Console.WriteLine("Drawing diamond ..."); ;
        }
    }
}
 //muilti level inheritance is supported