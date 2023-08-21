using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Toddler:Man
    {
        public new void Play() //method hiding
        {
            Console.Write("toddler plays ");
        }

        public void Sleep() 
        {

            Console.WriteLine("Toddler sleeps ");
        }
    }
}
