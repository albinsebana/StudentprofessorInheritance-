using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondDemo2.Model
{
    internal class Animal
    {
        public virtual void Eat() 
        {
            Console.WriteLine("Animal is Eating ...");
        }   
    }
}
